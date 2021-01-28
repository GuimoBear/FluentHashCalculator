namespace FluentHashCalculator.Tests.Fakes
{
    public class SHA512EntityAbstractHashCalculator : AbstractHashCalculator<Entity>.SHA512
    {
        public SHA512EntityAbstractHashCalculator()
        {
            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.Birthday).And
                .Using(e => e.Age());
        }
    }
}
