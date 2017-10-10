using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
        myLable:
            if (counter < 10)
            {
                counter++;
                goto myLable;
            }
            else
                Console.WriteLine("Done");
            Console.WriteLine(counter);
            Console.ReadKey();

            // P.S we dont use goto alot because its kind of slow and old
            // and because there is forloop
        }
    }
}
