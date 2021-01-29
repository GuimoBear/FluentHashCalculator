namespace FluentHashCalculator.Tests.Fakes
{
    public class SHA384EntityAbstractHashCalculator : AbstractHashCalculator<Entity>.SHA384
    {
        public SHA384EntityAbstractHashCalculator(bool ignoreErrors = true)
        {
            IgnoreErrors = ignoreErrors;

            Calculate
                .Using(e => e.Id).And
                .Using(e => e.Name).And
                .Using(e => e.LastName).And
                .Using(e => e.Birthday).And
                .Using(e => e.Another.Id).And
                .Using(e => e.Another.Name).And
                .Using(e => e.Another.Birthday).And
                .Using(e => e.Null.Name, ignoreError: true).And
                .Using(e => e.Age());
        }
    }
}
