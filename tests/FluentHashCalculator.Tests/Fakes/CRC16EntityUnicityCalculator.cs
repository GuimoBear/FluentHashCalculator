namespace FluentHashCalculator.Tests.Fakes
{
    public class CRC16EntityUnicityCalculator : AbstractHashCalculator<Entity>.CRC16
    {
        public CRC16EntityUnicityCalculator()
        {
            Calculate
                .Using(e => e.Id)
                .Using(e => e.Name)
                .Using(e => e.Birthday)
                .Using(e => e.Age());
        }
    }
}
