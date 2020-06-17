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

            var query = 
                from developer in developers
                orderby developer.Name
                where developer.Name.Length==5
                select developer.Name;

            var query2 = developers
                .Where(x => x.Name.Length == 5)
                .OrderBy(x => x.Name)
                .Select(x=>x.Name)
                .ToList();

            foreach (var developer in query)
                Console.WriteLine(developer);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
