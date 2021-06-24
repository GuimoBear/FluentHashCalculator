using FluentHashCalculator.Internal;
using System;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculatorBuilder<T>
           where T : class
    {
        public class HashCode : AbstractHashCalculatorBuilder<T>, IAbstractHashCalculator<T, int>
        {
            public int Compute(T instance)
            {
                if (ReferenceEquals(instance, null))
                    return 0;
                var crc = uint.MinValue;
                foreach ((var value, var context) in ValuesFor(instance))
                    if (value is byte[] bytes)
                        crc = Crc32.Compute(bytes, crc);
                    else
                        foreach (var item in Bytes.From(value, context))
                            crc = Crc32.Compute(item, crc);

                return Convert.ToInt32(int.MinValue + crc);
            }
        }
    }
}
