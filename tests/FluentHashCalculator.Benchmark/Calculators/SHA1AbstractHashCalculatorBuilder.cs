using FluentHashCalculator.Internal;
using System.Security.Cryptography;

namespace FluentHashCalculator.Benchmark.Calculators
{
    public abstract partial class AbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class SHA1 : FluentHashCalculator.AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, byte[]>
        {
            private static readonly HashAlgorithm algorithm
                = System.Security.Cryptography.SHA1.Create();

            public byte[] Compute(T instance)
            {
                if (ReferenceEquals(instance, null))
                    return Bytes.Empty;
                using (var hash = HashAggregatorPool.CreateReusable(HashAlgorithmName.SHA1))
                {
                    foreach ((var value, var context) in ValuesFor(instance))
                        foreach (var item in Bytes.From(value, context))
                            hash.Append(item);
                    return hash.GetAndReset();
                }
            }
        }
    }
}
