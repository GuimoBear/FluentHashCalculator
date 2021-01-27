namespace FluentHashCalculator.Tests.Fakes
{
    public class SHA256EntityUnicityCalculator : AbstractHashCalculator<Entity>.SHA256
    {
        public SHA256EntityUnicityCalculator()
        {
            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.Birthday).And
                .Using(e => e.Age());
        }
    }
}
