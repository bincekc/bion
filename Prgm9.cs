using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOfLinQ
{
    internal class Prgm9
    {
        public static void Main()
        {

            int[] num = { 7, 8, 6, 5, 12, 54, 77, 4, 15, 22 };

            // Count and display even numbers
            var evenNumbers = from order in num
                              where order % 2 == 0
                              select order;

            int evenCount = evenNumbers.Count();

            Console.WriteLine($"Count of even numbers: {evenCount}");
            Console.WriteLine("Even numbers:");

            foreach (var evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber);
            }
        }
    }
}
}
