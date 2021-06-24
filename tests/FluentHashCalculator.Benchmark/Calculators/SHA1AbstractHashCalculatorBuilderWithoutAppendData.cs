using FluentHashCalculator.Internal;
using System.Buffers;
using System.IO;

namespace FluentHashCalculator.Benchmark.Calculators
{
    public abstract partial class AbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class SHA1WithoutAppendData : FluentHashCalculator.AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, byte[]>
        {
            private static readonly System.Security.Cryptography.SHA1 hash
                = System.Security.Cryptography.SHA1.Create();

            public byte[] Compute(T instance)
            {
                if (ReferenceEquals(instance, null))
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
