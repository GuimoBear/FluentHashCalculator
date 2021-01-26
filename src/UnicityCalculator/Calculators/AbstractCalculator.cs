namespace UnicityCalculator
{
    public abstract partial class AbstractCalculator<T>
        where T: class
    {
        protected abstract IAbstractCalculatorBuilder<T> Calculate { get; }
    }
}
