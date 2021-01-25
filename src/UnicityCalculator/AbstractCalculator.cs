namespace UnicityCalculator
{
    public abstract class AbstractCalculator<T>
        where T: class
    {
        private readonly UnicityCalculator<T> calculator
            = new UnicityCalculator<T>();
        protected ICalculatorMaker<T> Calculate => calculator;

        public ulong Compute(T instance)
            => calculator.Compute(instance);
    }
}
