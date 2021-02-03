namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculator<T>
        where T: class
    {
        public class CRC32 : AbstractHashCalculator<T>, ICRC32Calculator<T>
        {
            protected readonly IAbstractHashCalculator<T, uint> Calculator
                = new AbstractHashCalculatorBuilder<T>.CRC32();

            protected override IAbstractHashCalculatorBuilder<T> Calculate => Calculator;

            public uint Compute(T instance)
            {
                return Calculator.Compute(instance);
            }
        }
    }
}
