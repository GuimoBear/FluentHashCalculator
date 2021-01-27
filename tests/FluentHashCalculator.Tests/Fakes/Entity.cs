using System;

namespace FluentHashCalculator.Tests.Fakes
{
    public class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public AnotherEntity Another { get; set; }

        public int Age()
        {
            var now = DateTime.Now;

            if (now.DayOfYear >= Birthday.DayOfYear)
                return now.Year - Birthday.Year;
            return now.Year - Birthday.Year - 1;
        }
    }
}
