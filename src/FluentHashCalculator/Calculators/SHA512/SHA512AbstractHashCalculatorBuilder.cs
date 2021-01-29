using FluentHashCalculator.Internal;
using System.Security.Cryptography;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class SHA512 : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, byte[]>
        {
            private static readonly ObjectPool<IncrementalHash> pool
                = new(() => IncrementalHash.CreateHash(HashAlgorithmName.SHA512));

            public byte[] Compute(T instance)
            {
                if (instance is null)
                    return Bytes.Empty;

                using (var container = pool.Acquire())
                {
                    foreach ((var value, var context) in ValuesFor(instance))
                        foreach (var item in Bytes.From(value, context))
                            container.Instance.AppendData(item);
                    return container.Instance.GetHashAndReset();
                }
            }
        }
    }
}
