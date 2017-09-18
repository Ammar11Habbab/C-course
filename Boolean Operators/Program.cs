using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean comparsion ==, !=, <, >, <=, >=
            //Boolean conditions $$, ||   
            //  && table
            //  T  T  = true
            //  T  F  = false
            //  F  F  = false


            //  || table
            //  T  T  = true
            //  T  F  = true
            //  F  F  = false

            bool var1;
            int myvar1 = 5, myvar2 = 8;
            //var1 = myvar1 == 5;
            var1 = (myvar1 == 1) || (myvar2 == 2);
            Console.WriteLine(" the result is = {0}", var1);
            Console.ReadKey();

        }
    }
}
