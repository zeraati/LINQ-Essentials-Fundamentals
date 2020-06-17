using System;
using System.Collections.Generic;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var developers = new []
            {
                new Employee {Id = 1, Name = "Ali"},
                new Employee {Id = 2, Name = "Hasan"}
            };

            var sales=new List<Employee>
            {
                new Employee{Id = 3,Name = "Hoda"}
            };

            var enumerator = sales.GetEnumerator();
            while (enumerator.MoveNext())
                Console.WriteLine(enumerator.Current.Id);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name{ get; set; }
    }

}
