namespace FluentHashCalculator.Tests.Fakes
{
    public class CRC64EntityAbstractHashCalculator : AbstractHashCalculator<Entity>.CRC64
    {
        public CRC64EntityAbstractHashCalculator()
        {
            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.Birthday).And
                .Using(e => e.Age());
        }
    }
}
