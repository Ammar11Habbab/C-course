using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implict_conversion__Conversion_between_variable_
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar1 = 1000;
            float myvar2 = myvar1;
            Console.WriteLine($"{myvar2}");
            char myvar3 = 'G';
            int myvar4 = myvar3;
            Console.WriteLine($"{myvar4}");


            Console.ReadKey();
        }
    }
}
