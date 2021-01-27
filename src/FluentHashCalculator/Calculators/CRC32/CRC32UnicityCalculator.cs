using FluentHashCalculator.Internal;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T> : IAbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class CRC32 : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, uint>
        {
            public uint Compute(T instance)
            {
                if (instance is null)
                    return uint.MinValue;
                var crc = uint.MinValue;
                foreach (var value in ValuesFor(instance))
                    foreach (var item in Bytes.From(value))
                        crc = Crc32.Compute(item, crc);

                return crc;
            }
        }
    }

    
}
