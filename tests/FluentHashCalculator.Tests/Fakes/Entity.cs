using System;
using System.Collections.Generic;

namespace FluentHashCalculator.Tests.Fakes
{
    public class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public AnotherEntity Another { get; set; }

        public IEnumerable<AnotherEntity> AnotherList { get; set; }

        public NullEntity Null { get; set; }

        public int Age()
            => 1;
    }

    public class NullEntity
    {
        public string Name { get; set; }
    }
}
