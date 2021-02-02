using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace FluentHashCalculator.Internal
{
    internal static class HashAggregatorPool
    {
        private const int SHA1_BYTES_COUNT = 160 / 8;
        private const int SHA256_BYTES_COUNT = 256 / 8;
        private const int SHA384_BYTES_COUNT = 384 / 8;
        private const int SHA512_BYTES_COUNT = 512 / 8;
        private const int MD5_BYTES_COUNT = 128 / 8;

        private static readonly IDictionary<HashAlgorithmName, (HashAlgorithm, ObjectPool<byte[]>)> hashAlgorithms;

        static HashAggregatorPool()
        {
            hashAlgorithms = new Dictionary<HashAlgorithmName, (HashAlgorithm, ObjectPool<byte[]>)>(5);
            hashAlgorithms.Add(HashAlgorithmName.SHA1, (SHA1.Create(), new ObjectPool<byte[]>(() => new byte[SHA1_BYTES_COUNT])));
            hashAlgorithms.Add(HashAlgorithmName.SHA256, (SHA256.Create(), new ObjectPool<byte[]>(() => new byte[SHA256_BYTES_COUNT])));
            hashAlgorithms.Add(HashAlgorithmName.SHA384, (SHA384.Create(), new ObjectPool<byte[]>(() => new byte[SHA384_BYTES_COUNT])));
            hashAlgorithms.Add(HashAlgorithmName.SHA512, (SHA512.Create(), new ObjectPool<byte[]>(() => new byte[SHA512_BYTES_COUNT])));
            hashAlgorithms.Add(HashAlgorithmName.MD5, (MD5.Create(), new ObjectPool<byte[]>(() => new byte[MD5_BYTES_COUNT])));
        }

        internal static HashAggregator CreateReusable(HashAlgorithmName hashAlgorithmName)
            => new HashAggregator(hashAlgorithmName);

        private static (HashAlgorithm, ObjectPool<byte[]>) GetHashProcessors(HashAlgorithmName hashAlgorithmName)
        {
            if (hashAlgorithms.TryGetValue(hashAlgorithmName, out var processors))
                return processors;
            throw new ArgumentException($"The {hashAlgorithmName.Name} algorithm was not found");
        }

        internal class HashAggregator : IDisposable
        {
            private readonly HashAlgorithm algorithm;
            private readonly ObjectPool<byte[]>.Container container;

            internal HashAggregator(HashAlgorithmName hashAlgorithmName)
            {
                var (_algorithm, _pool) = GetHashProcessors(hashAlgorithmName);
                container = _pool.Acquire();
                algorithm = _algorithm;
            }

            public void Append(byte[] bytes)
                => Bytes.XOR(algorithm.ComputeHash(bytes), container.Instance);

            public byte[] GetAndReset()
            {
                try
                {
                    return container.Instance.ToArray();
                }
                finally
                {
                    Array.Fill(container.Instance, byte.MinValue);
                }
            }

            public void Dispose()
                => container.Dispose();
        }
    }
}
