using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        public static int printnumber(int mynumber)
        {
            return mynumber;
        }
        public static double printnumber(double mynumber)
        {
            return mynumber;
        }
        static void Main(string[] args)
        {

            int mynumber = 9;
            Console.Write($"{printnumber(mynumber)}");
            Console.ReadKey();
            // overloading is that we can define 2 functions same name and diffrent variables same name also
            // and return them diffrent also
        }
    }
}
