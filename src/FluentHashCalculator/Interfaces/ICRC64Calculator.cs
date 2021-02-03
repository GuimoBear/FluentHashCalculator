namespace FluentHashCalculator
{
    public interface ICRC64Calculator<T> : IHashCalculator<T, ulong>
        where T : class
    {
    }
}
