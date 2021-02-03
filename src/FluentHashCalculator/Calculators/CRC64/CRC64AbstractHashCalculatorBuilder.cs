using FluentHashCalculator.Internal;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class CRC64 : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, ulong>
        {
            public ulong Compute(T instance)
            {
                if (instance is null)
                    return ulong.MinValue;
                ulong crc = 0;
                foreach ((var value, var context) in ValuesFor(instance))
                    if (value is byte[] bytes)
                        crc = Crc64.Compute(bytes, crc);
                    else
                        foreach (var item in Bytes.From(value, context))
                            crc = Crc64.Compute(item, crc);

                return crc;
            }
        }
    }

    
}
