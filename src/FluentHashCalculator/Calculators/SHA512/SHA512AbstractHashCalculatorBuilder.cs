using FluentHashCalculator.Internal;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class SHA512 : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, byte[]>
        {
            private static readonly System.Security.Cryptography.HashAlgorithm hash
                = System.Security.Cryptography.SHA512.Create();

            public byte[] Compute(T instance)
            {
                if (ReferenceEquals(instance, null))
                    return Bytes.Empty;
                using (var mem = new System.IO.MemoryStream())
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
