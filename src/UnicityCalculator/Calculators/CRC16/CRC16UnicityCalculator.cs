using UnicityCalculator.Internal;

namespace UnicityCalculator
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
                    crc = Crc16.Compute(Bytes.From(value), crc);

                return crc;
            }
        }
    }

    
}
