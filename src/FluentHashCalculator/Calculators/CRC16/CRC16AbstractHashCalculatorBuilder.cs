using FluentHashCalculator.Internal;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class CRC16 : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, ushort>
        {
            public ushort Compute(T instance)
            {
                if (ReferenceEquals(instance, null))
                    return ushort.MinValue;
                var crc = ushort.MinValue;
                foreach ((var value, var context) in ValuesFor(instance))
                    if (value is byte[] bytes)
                        crc = Crc16.Compute(bytes, crc);
                    else
                        foreach (var item in Bytes.From(value, context))
                            crc = Crc16.Compute(item, crc);

                return crc;
            }
        }
    }

    
}
