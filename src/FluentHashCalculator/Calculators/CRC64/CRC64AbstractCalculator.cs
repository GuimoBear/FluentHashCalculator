namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculator<T>
        where T: class
    {
        public class CRC64 : AbstractHashCalculator<T>, ICRC64Calculator<T>
        {
            protected readonly IAbstractHashCalculator<T, ulong> Calculator
                = new AbstractHashCalculatorBuilder<T>.CRC64();

            protected override IAbstractHashCalculatorBuilder<T> Calculate => Calculator;

            public ulong Compute(T instance)
            {
                return Calculator.Compute(instance);
            }
        }
    }
}
