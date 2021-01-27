namespace FluentHashCalculator
{
    public abstract partial class AbstractHashCalculator<T>
        where T: class
    {
        protected abstract IAbstractHashCalculatorBuilder<T> Calculate { get; }
    }
}
