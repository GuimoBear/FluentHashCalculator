namespace FluentHashCalculator.Tests.Fakes
{
    public class SHA256WithUTF32EncodingEntityAbstractHashCalculator : AbstractHashCalculator<Entity>.SHA256
    {
        public SHA256WithUTF32EncodingEntityAbstractHashCalculator(bool ignoreErrors = true)
        {
            IgnoreErrors = ignoreErrors;

            Encoding = System.Text.Encoding.UTF32;

            Calculate
                .Using(e => e.Id)
                .Using(e => e.Name)
                .Using(e => e.LastName)
                .Using(e => e.Birthday)
                .Using(e => e.Another).WithSHA256(calc => calc.Using(p => p.Id).Using(p => p.Name, encoding: Encoding).Using(p => p.Birthday))
                .UsingEach(e => e.AnotherList).WithSHA256(calc => calc.Using(p => p.Id))
                .Using(e => e.Null.Name, ignoreError: true)
                .Using(e => e.Age());
        }
    }
}
