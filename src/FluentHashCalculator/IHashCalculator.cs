namespace FluentHashCalculator
{
    public interface IHashCalculator<T, TComputedType>
        where T: class
    {
        TComputedType Compute(T instance);
    }
}
