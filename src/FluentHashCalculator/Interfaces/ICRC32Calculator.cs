namespace FluentHashCalculator
{
    public interface ICRC32Calculator<T> : IHashCalculator<T, uint>
        where T : class
    {

    }
}
