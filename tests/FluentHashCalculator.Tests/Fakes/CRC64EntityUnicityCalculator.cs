namespace FluentHashCalculator.Tests.Fakes
{
    public class CRC64EntityUnicityCalculator : AbstractHashCalculator<Entity>.CRC64
    {
        public CRC64EntityUnicityCalculator()
        {
            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.Birthday).And
                .Using(e => e.Age());
        }
    }
}
