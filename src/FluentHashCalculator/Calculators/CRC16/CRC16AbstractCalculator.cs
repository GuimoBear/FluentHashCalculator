namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculator<T>
        where T: class
    {
        public class CRC16 : AbstractHashCalculator<T>, ICRC16Calculator<T>
        {
            protected readonly IAbstractHashCalculator<T, ushort> Calculator
                = new AbstractHashCalculatorBuilder<T>.CRC16();

            protected override IAbstractHashCalculatorBuilder<T> Calculate => Calculator;

            public ushort Compute(T instance)
            {
                return Calculator.Compute(instance);
            }
        }
    }
}
