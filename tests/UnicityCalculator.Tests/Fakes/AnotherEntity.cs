using System;

namespace UnicityCalculator.Tests.Fakes
{
    public class AnotherEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int Age()
        {
            var now = DateTime.Now;

            if (now.DayOfYear >= Birthday.DayOfYear)
                return now.Year - Birthday.Year;
            return now.Year - Birthday.Year - 1;
        }
    }
}
