using FluentHashCalculator.Internal;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T> : IAbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class CRC16 : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, ushort>
        {
            public ushort Compute(T instance)
            {
                if (instance is null)
                    return ushort.MinValue;
                var crc = ushort.MinValue;
                foreach (var value in ValuesFor(instance))
                    foreach(var item in Bytes.From(value))
                        crc = Crc16.Compute(item, crc);

                return crc;
            }
        }
    }

    
}
