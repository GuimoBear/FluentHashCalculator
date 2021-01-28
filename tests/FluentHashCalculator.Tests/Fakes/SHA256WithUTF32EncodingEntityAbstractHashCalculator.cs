namespace FluentHashCalculator.Tests.Fakes
{
    public class SHA256WithUTF32EncodingEntityAbstractHashCalculator : AbstractHashCalculator<Entity>.SHA256
    {
        public SHA256WithUTF32EncodingEntityAbstractHashCalculator()
        {
            Encoding = System.Text.Encoding.UTF32;

            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.Birthday).And
                .Using(e => e.Age());
        }
    }
}
