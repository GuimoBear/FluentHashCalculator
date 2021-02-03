namespace FluentHashCalculator.Tests.Fakes
{
    public class CRC64EntityAbstractHashCalculator : AbstractHashCalculator<Entity>.CRC64
    {
        public CRC64EntityAbstractHashCalculator(bool ignoreErrors = true)
        {
            IgnoreErrors = ignoreErrors;

            Calculate
                .Using(e => e.Id)
                .Using(e => e.Name)
                .Using(e => e.LastName)
                .Using(e => e.Birthday)
                .Using(e => e.Another).WithCRC64(calc => calc.Using(p => p.Id).Using(p => p.Name).Using(p => p.Birthday))
                .UsingEach(e => e.AnotherList).WithCRC64(calc => calc.Using(p => p.Id))
                .Using(e => e.Null.Name, ignoreError: true)
                .Using(e => e.Age());
        }
    }
}
