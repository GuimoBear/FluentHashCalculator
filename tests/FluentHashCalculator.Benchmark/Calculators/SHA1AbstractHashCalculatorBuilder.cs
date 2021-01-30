using FluentHashCalculator.Internal;
using System.Security.Cryptography;

namespace FluentHashCalculator.Benchmark.Calculators
{
    public abstract partial class AbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class SHA1 : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, byte[]>
        {
            public byte[] Compute(T instance)
            {
                if (instance is null)
                    return Bytes.Empty;
                using (var incrementalHash = IncrementalHash.CreateHash(HashAlgorithmName.SHA1))
                {
                    foreach ((var value, var context) in ValuesFor(instance))
                        foreach (var item in Bytes.From(value, context))
                            incrementalHash.AppendData(item);
                    return incrementalHash.GetHashAndReset();
                }
            }
        }
    }
}
