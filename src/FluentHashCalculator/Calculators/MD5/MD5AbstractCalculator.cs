using System;

namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculator<T>
        where T: class
    {
        public class MD5 : AbstractHashCalculator<T>, IMD5Calculator<T>
        {
            protected readonly IAbstractHashCalculator<T, byte[]> Calculator
                = new AbstractHashCalculatorBuilder<T>.MD5();

            protected override IAbstractHashCalculatorBuilder<T> Calculate => Calculator;

            public string Base64(T instance)
                => Convert.ToBase64String(Compute(instance));

            public byte[] Compute(T instance)
            {
                return Calculator.Compute(instance);
            }
        }
    }
}
