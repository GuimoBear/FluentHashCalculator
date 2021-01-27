namespace FluentHashCalculator.Tests.Fakes
{
    public class CRC32EntityUnicityCalculator : AbstractHashCalculator<Entity>.CRC32
    {
        public CRC32EntityUnicityCalculator()
        {
            Calculate
                .Using(e => e.Id)
                .Using(e => e.Name)
                .Using(e => e.Birthday)
                .Using(e => e.Age());
        }
    }
}
