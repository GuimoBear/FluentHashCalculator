namespace UnicityCalculator.Tests.Fakes
{
    public class EntityUnicityCalculator : AbstractCalculator<Entity>.CRC64
    {
        public EntityUnicityCalculator()
        {
            Calculate
                .Using(e => e.Id)
                .Using(e => e.Name)
                .Using(e => e.Birthday)
                .Using(e => e.Age());
        }
    }
}
