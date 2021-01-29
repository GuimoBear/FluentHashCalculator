namespace FluentHashCalculator.Tests.Fakes
{
    public class SHA256WithUTF32EncodingEntityAbstractHashCalculator : AbstractHashCalculator<Entity>.SHA256
    {
        public SHA256WithUTF32EncodingEntityAbstractHashCalculator(bool ignoreErrors = true)
        {
            IgnoreErrors = ignoreErrors;

            Encoding = System.Text.Encoding.UTF32;

            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.LastName).And
                .Using(e => e.Birthday).And
                .Using(e => e.Another.Id).And
                .Using(e => e.Another.Name).And
                .Using(e => e.Another.Birthday).And
                .Using(e => e.Null.Name, ignoreError: true).And
                .Using(e => e.Age());
        }
    }
}
