namespace FluentHashCalculator.Tests.Fakes
{
    public class SHA1EntityUnicityCalculator : AbstractHashCalculator<Entity>.SHA1
    {
        public SHA1EntityUnicityCalculator()
        {
            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.Birthday).And
                .Using(e => e.Age());
        }
    }
}
