namespace FluentHashCalculator
{
    public interface IAbstractHashCalculator<T, TComputedType> : IAbstractHashCalculatorBuilder<T>, IHashCalculator<T, TComputedType>
        where T: class
    {

    }
}
