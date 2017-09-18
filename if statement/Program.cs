using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statement
{
    class Program
    {
        static void Main(string[] args)
        {

            //int myvar1 = 10;
            //int mrvar2 = 20;

            //if ((myvar1 == 10) && (mrvar2 == 20))
            //{
            //    Console.WriteLine("well done");
            //}
            //else
            //{
            //    Console.WriteLine("work harder");
            //}
            //    Console.ReadKey();

            int myvar1 = 10;
            string myresult;
            if (myvar1 < 10)
            {
                myresult = "less than 10";
                Console.WriteLine(myresult);
            }
            if (myvar1 > 10)
            {
                myresult = "more than 10";
                Console.WriteLine(myresult);
            }
            if (myvar1 == 10)
            {
                myresult = "equal 10";
                Console.WriteLine(myresult);
            }
            Console.ReadKey();
        }
    }
}
