namespace FluentHashCalculator.Tests.Fakes
{
    public class CRC16EntityAbstractHashCalculator : AbstractHashCalculator<Entity>.CRC16
    {
        public CRC16EntityAbstractHashCalculator(bool ignoreErrors = true)
        {
            IgnoreErrors = ignoreErrors;

            Calculate
                .Using(e => e.Id)
                .Using(e => e.Name)
                .Using(e => e.LastName)
                .Using(e => e.Birthday)
                .Using(e => e.Another).WithCRC16(calc => calc.Using(p => p.Id).Using(p => p.Name).Using(p => p.Birthday))
                .UsingEach(e => e.AnotherList).WithCRC16(calc => calc.Using(p => p.Id))
                .Using(e => e.Null.Name, ignoreError: true)
                .Using(e => e.Age());
        }
    }
}
