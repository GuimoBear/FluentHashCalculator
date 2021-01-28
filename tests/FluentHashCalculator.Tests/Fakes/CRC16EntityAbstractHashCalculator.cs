namespace FluentHashCalculator.Tests.Fakes
{
    public class CRC16EntityAbstractHashCalculator : AbstractHashCalculator<Entity>.CRC16
    {
        public CRC16EntityAbstractHashCalculator()
        {
            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.Birthday).And
                .Using(e => e.Age());
        }
    }
}
