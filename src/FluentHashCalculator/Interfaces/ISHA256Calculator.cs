namespace FluentHashCalculator
{
    public interface ISHA256Calculator<T> : IHashCalculator<T, byte[]>, IBase64Representation<T>
        where T : class
    { 
    }
}
