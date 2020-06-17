using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var developers = new[]
            {
                new Employee {Id = 1, Name = "Ali"},
                new Employee {Id = 1, Name = "Ahmad"},
                new Employee {Id = 2, Name = "Hasan"}
            };

            foreach (var developer in developers
                                                .Where(x => x.Name.Length == 5)
                                                .OrderBy(x => x.Name))
                Console.WriteLine(developer.Name);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
