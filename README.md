<h1 align="center">FluentHashCalculator</h1>

Example: 

```cs
using FluentHashCalculator;
using System;

namespace Test
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public DateTime Birthday { get; set; }
        }

        public class PersonHashCalculator : AbstractHashCalculator<Person>.CRC32
        {
            public PersonHashCalculator()
            {
                Calculate
                    .Using(p => p.Name)
                    .Using(e => e.Birthday);
            }
        }

        static void Main(string[] args)
        {
            var crc32Calculator = new PersonHashCalculator();

            var person = new Person
            {
                Name = "John Krasinski", 
                Birthday = new DateTime(1979, 10, 20)
            };

            var crc32 = crc32Calculator.Compute(person);

            // Print 1158920806
            Console.WriteLine(crc32);
        }
    }
}
```

By default, errors thrown when reading object data are ignored, to change this, exists three ways

```cs
// Using global settings
FluentHashCalculator.GlobalSettings.IgnoreErrors = false;

// In the calculator constructor method 
public PersonHashCalculator()
{
    IgnoreErrors = false;

    Calculate
        .Using(p => p.Name)
        .Using(e => e.Birthday);
}

// During Using is called
Calculate
    .Using(p => p.Name, ignoreError: false)
    .Using(e => e.Birthday);
```

> In these ways, it's possible to configure the throw of exceptions globally, internally in the calculator and in a specific field, respectively

By default, strings bytes has extracted using `Encoding.UTF8`, to change this, exists three ways

```cs
// Using global settings
FluentHashCalculator.GlobalSettings.StringSettings.Encoding = System.Text.Encoding.Latin1;

// In the calculator constructor method 
public PersonHashCalculator()
{
    Encoding = System.Text.Encoding.Latin1;

    Calculate
        .Using(p => p.Name)
        .Using(e => e.Birthday);
}

// During Using is called
Calculate
    .Using(p => p.Name, encoding: System.Text.Encoding.Latin1)
    .Using(e => e.Birthday);
```

> In these ways, it's possible to configure the string encoding globally, internally in the calculator and in a specific field, respectively
