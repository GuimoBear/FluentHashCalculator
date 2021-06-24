namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculator<T>
        where T : class
    {
        public class HashCode : AbstractHashCalculator<T>, IHashCodeCalculator<T>
        {
            protected readonly IAbstractHashCalculator<T, int> Calculator
                = new AbstractHashCalculatorBuilder<T>.HashCode();

            protected override IAbstractHashCalculatorBuilder<T> Calculate => Calculator;

            public int Compute(T instance)
            {
                return Calculator.Compute(instance);
            }
        }
    }
}
