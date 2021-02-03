namespace FluentHashCalculator
{
    public interface IMD5Calculator<T> : IHashCalculator<T, byte[]>, IBase64Representation<T>
        where T : class
    { 
    }
}
