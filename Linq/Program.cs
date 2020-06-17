using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> Sequence = x => x * x;
            //Func<int, int, int> Plus = (x, y) => x + y;
            //Func<int, int, int> Plus2 = (x, y) =>
            // {
            //     var plus2 = x + y + 2;
            //     return plus2;
            // };

            int Sequence( int x) => x * x;
            int Plus(int x, int y) => x + y;

            int Plus2(int x, int y)
            {
                var plus2 = x + y + 2;
                return plus2;
            }

            Console.WriteLine(Sequence(2));
            Console.WriteLine(Plus(2, 3));
            Console.WriteLine(Plus2(2, 3));
        }
    }

}
