using FluentHashCalculator.Internal;
using System.IO;
using System.Security.Cryptography;

namespace FluentHashCalculator.Benchmark.Calculators
{
    public abstract partial class AbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class SHA256WithoutAppendData : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, byte[]>
        {
            private static readonly HashAlgorithm hash
                = System.Security.Cryptography.SHA256.Create();

            public byte[] Compute(T instance)
            {
                if (instance is null)
                    return Bytes.Empty;
                using (var mem = new MemoryStream())
                {
                    foreach ((var value, var context) in ValuesFor(instance))
                        foreach (var item in Bytes.From(value, context))
                            mem.Write(item);
                    return hash.ComputeHash(mem.ToArray());
                }
            }
        }
    }

    
}
