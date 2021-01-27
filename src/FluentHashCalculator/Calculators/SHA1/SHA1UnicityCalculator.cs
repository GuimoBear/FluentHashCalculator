using FluentHashCalculator.Internal;
using System.Security.Cryptography;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T> : IAbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class SHA1 : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, byte[]>
        {
            private static readonly DisposableObjectPool<IncrementalHash> pool
                = new DisposableObjectPool<IncrementalHash>(() => IncrementalHash.CreateHash(HashAlgorithmName.SHA1));

            public byte[] Compute(T instance)
            {
                if (instance is null)
                    return Bytes.Empty;

                using (var container = pool.Acquire())
                {
                    foreach (var value in ValuesFor(instance))
                        foreach (var item in Bytes.From(value))
                            container.Instance.AppendData(item);
                    return container.Instance.GetHashAndReset();
                }
            }
        }
    }

    
}
