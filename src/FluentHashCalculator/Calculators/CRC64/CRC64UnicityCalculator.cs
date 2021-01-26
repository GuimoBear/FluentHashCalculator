using FluentHashCalculator.Internal;

namespace FluentHashCalculator
{
    public abstract partial class AbstractCalculatorBuilder<T> : IAbstractCalculatorBuilder<T>
           where T : class
    {
        public class CRC64 : AbstractCalculatorBuilder<T>, IAbstractCalculator<T, ulong>
        {
            public ulong Compute(T instance)
            {
                if (instance is null)
                    return ulong.MinValue;
                ulong crc = 0;
                foreach (var value in ValuesFor(instance))
                    crc = Crc64.Compute(Bytes.From(value), crc);

                return crc;
            }
        }
    }

    
}
