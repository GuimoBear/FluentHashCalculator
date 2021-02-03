namespace FluentHashCalculator
{
    public interface ISHA384Calculator<T> : IHashCalculator<T, byte[]>, IBase64Representation<T>
        where T : class
    { 
    }
}
