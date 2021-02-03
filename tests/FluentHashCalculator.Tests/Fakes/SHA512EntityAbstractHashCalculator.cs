namespace FluentHashCalculator.Tests.Fakes
{
    public class SHA512EntityAbstractHashCalculator : AbstractHashCalculator<Entity>.SHA512
    {
        public SHA512EntityAbstractHashCalculator(bool ignoreErrors = true)
        {
            IgnoreErrors = ignoreErrors;

            Calculate
                .Using(e => e.Id)
                .Using(e => e.Name)
                .Using(e => e.LastName)
                .Using(e => e.Birthday)
                .Using(e => e.Another).WithSHA512(calc => calc.Using(p => p.Id).Using(p => p.Name).Using(p => p.Birthday))
                .UsingEach(e => e.AnotherList).WithSHA512(calc => calc.Using(p => p.Id))
                .Using(e => e.Null.Name, ignoreError: true)
                .Using(e => e.Age());
        }
    }
}
