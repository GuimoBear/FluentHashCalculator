namespace FluentHashCalculator
{
    public interface ICRC16Calculator<T> : IHashCalculator<T, ushort>
        where T : class
    {
    }
}
