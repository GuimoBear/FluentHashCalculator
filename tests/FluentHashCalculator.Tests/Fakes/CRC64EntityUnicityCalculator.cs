namespace FluentHashCalculator.Tests.Fakes
{
    public class CRC64EntityUnicityCalculator : AbstractHashCalculator<Entity>.CRC64
    {
        public CRC64EntityUnicityCalculator()
        {
            Calculate
                .Using(e => e.Id)
                .Using(e => e.Name)
                .Using(e => e.Birthday)
                .Using(e => e.Age());
        }
    }
}
