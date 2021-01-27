using FluentHashCalculator.Internal;

namespace FluentHashCalculator
{
    public abstract partial class AbstractCalculatorBuilder<T> : IAbstractCalculatorBuilder<T>
           where T : class
    {
        public class CRC16 : AbstractCalculatorBuilder<T>, IAbstractCalculator<T, ushort>
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
