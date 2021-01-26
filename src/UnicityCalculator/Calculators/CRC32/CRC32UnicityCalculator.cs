using UnicityCalculator.Internal;

namespace UnicityCalculator
{
    public abstract partial class AbstractCalculatorBuilder<T> : IAbstractCalculatorBuilder<T>
           where T : class
    {
        public class CRC32 : AbstractCalculatorBuilder<T>, IAbstractCalculator<T, uint>
        {
            public uint Compute(T instance)
            {
                if (instance is null)
                    return uint.MinValue;
                var crc = uint.MinValue;
                foreach (var value in ValuesFor(instance))
                    crc = Crc32.Compute(Bytes.From(value), crc);

                return crc;
            }
        }
    }

    
}
