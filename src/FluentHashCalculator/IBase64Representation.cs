namespace FluentHashCalculator
{
    public interface IBase64Representation<T>
        where T : class
    {
        string Base64(T instance);
    }
}
