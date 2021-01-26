namespace FluentHashCalculator
{
    public abstract partial class AbstractCalculator<T>
        where T: class
    {
        public class CRC64 : AbstractCalculator<T>, ICalculator<T, ulong>
        {
            protected readonly IAbstractCalculator<T, ulong> Calculator
                = new AbstractCalculatorBuilder<T>.CRC64();

            protected override IAbstractCalculatorBuilder<T> Calculate => Calculator;

            public ulong Compute(T instance)
            {
                return Calculator.Compute(instance);
            }
        }
    }
}
