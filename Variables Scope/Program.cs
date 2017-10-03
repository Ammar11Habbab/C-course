using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Scope
{
    class Program
    {
        static string mystring;
        static void printmystring()
        {

            string mystring = "this string is in my print method";
            Console.WriteLine($"{mystring}");
            Console.WriteLine($"{Program.mystring}");

        }
        static void Main(string[] args)
        {

            string mystring = "this string is in my main method";
            Program.mystring = "Global String";
            printmystring();
            Console.WriteLine($"{mystring}");
            Console.WriteLine($"{Program.mystring}");
            Console.ReadKey();
            // we use the first function on the top to make a global variable that we can use
            // in all functions and have the same value

        }
    }
}
