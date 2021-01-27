namespace FluentHashCalculator.Tests.Fakes
{
    public class SHA512EntityUnicityCalculator : AbstractHashCalculator<Entity>.SHA512
    {
        public SHA512EntityUnicityCalculator()
        {
            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.Birthday).And
                .Using(e => e.Age());
        }
    }
}
