using FluentHashCalculator.Internal;
using System.Security.Cryptography;

namespace FluentHashCalculator.Benchmark.Calculators
{
    public abstract partial class AbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class SHA384 : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, byte[]>
        {
            private static readonly HashAlgorithm algorithm
                = System.Security.Cryptography.SHA384.Create();

            public byte[] Compute(T instance)
            {
                if (instance is null)
                    return Bytes.Empty;
                using (var hash = HashAggregatorPool.CreateReusable(HashAlgorithmName.SHA384))
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
