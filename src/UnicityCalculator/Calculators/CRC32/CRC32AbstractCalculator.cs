namespace UnicityCalculator
{
    public abstract partial class AbstractCalculator<T>
        where T: class
    {
        public class CRC32 : AbstractCalculator<T>, ICalculator<T, uint>
        {
            protected readonly IAbstractCalculator<T, uint> Calculator
                = new AbstractCalculatorBuilder<T>.CRC32();

            protected override IAbstractCalculatorBuilder<T> Calculate => Calculator;

            public uint Compute(T instance)
            {
                return Calculator.Compute(instance);
            }
        }
    }
}
