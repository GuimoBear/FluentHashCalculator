namespace FluentHashCalculator
{
    public interface IHashCodeCalculator<T> : IHashCalculator<T, int>
        where T : class
    {

    }
}
