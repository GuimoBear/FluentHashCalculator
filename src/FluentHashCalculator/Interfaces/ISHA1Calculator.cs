namespace FluentHashCalculator
{
    public interface ISHA1Calculator<T> : IHashCalculator<T, byte[]>, IBase64Representation<T>
        where T : class
    { 
    }
}
