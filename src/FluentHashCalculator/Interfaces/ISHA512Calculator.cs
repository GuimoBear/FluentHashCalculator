namespace FluentHashCalculator
{
    public interface ISHA512Calculator<T> : IHashCalculator<T, byte[]>, IBase64Representation<T>
        where T : class
    { 
    }
}
