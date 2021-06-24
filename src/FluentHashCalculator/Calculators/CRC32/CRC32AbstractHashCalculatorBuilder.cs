using FluentHashCalculator.Internal;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class CRC32 : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, uint>
        {
            public uint Compute(T instance)
            {
                if (ReferenceEquals(instance, null))
                    return uint.MinValue;
                var crc = uint.MinValue;
                foreach ((var value, var context) in ValuesFor(instance))
                    if (value is byte[] bytes)
                        crc = Crc32.Compute(bytes, crc);
                    else
                        foreach (var item in Bytes.From(value, context))
                            crc = Crc32.Compute(item, crc);

                return crc;
            }
        }
    }

    
}
