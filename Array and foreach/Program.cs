using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // use foreach is safer than for because in for you can make an index mistake
            int[] mynumbers = { 1, 5, 7, 9, 3 };
            foreach (int item in mynumbers)
            {
                Console.WriteLine("My Number is " + $"{item}");
            }

            Console.ReadKey();
        }
    }
}
