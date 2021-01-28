namespace FluentHashCalculator.Tests.Fakes
{
    public class CRC32EntityAbstractHashCalculator : AbstractHashCalculator<Entity>.CRC32
    {
        public CRC32EntityAbstractHashCalculator()
        {
            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.Birthday).And
                .Using(e => e.Age());
        }
    }
}
