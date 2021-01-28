namespace FluentHashCalculator.Tests.Fakes
{
    public class SHA384EntityAbstractHashCalculator : AbstractHashCalculator<Entity>.SHA384
    {
        public SHA384EntityAbstractHashCalculator()
        {
            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.Birthday).And
                .Using(e => e.Age());
        }
    }
}
