namespace UnicityCalculator
{
    public abstract partial class AbstractCalculator<T>
        where T: class
    {
        public class CRC16 : AbstractCalculator<T>, ICalculator<T, ushort>
        {
            protected readonly IAbstractCalculator<T, ushort> Calculator
                = new AbstractCalculatorBuilder<T>.CRC16();

            protected override IAbstractCalculatorBuilder<T> Calculate => Calculator;

            public ushort Compute(T instance)
            {
                return Calculator.Compute(instance);
            }
        }
    }
}
