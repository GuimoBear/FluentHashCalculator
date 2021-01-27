namespace FluentHashCalculator.Tests.Fakes
{
    public class SHA384EntityUnicityCalculator : AbstractHashCalculator<Entity>.SHA384
    {
        public SHA384EntityUnicityCalculator()
        {
            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.Birthday).And
                .Using(e => e.Age());
        }
    }
}
