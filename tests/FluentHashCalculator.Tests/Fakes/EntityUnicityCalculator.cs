namespace FluentHashCalculator.Tests.Fakes
{
    public class EntityFluentHashCalculator : AbstractCalculator<Entity>.CRC64
    {
        public EntityFluentHashCalculator()
        {
            Calculate
                .Using(e => e.Id)
                .Using(e => e.Name)
                .Using(e => e.Birthday)
                .Using(e => e.Age());
        }
    }
}
