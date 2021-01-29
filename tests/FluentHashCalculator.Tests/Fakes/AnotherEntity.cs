using System;

namespace FluentHashCalculator.Tests.Fakes
{
    public class AnotherEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int Age()
            => 1;
    }
}
