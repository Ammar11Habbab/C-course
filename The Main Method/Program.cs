using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Main_Method
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine($"{args.Length} command line arguments has entered");
            foreach (string arg in args)
            {

                Console.WriteLine(arg);
            }
            Console.ReadKey();


            return 0;
            // we can change the main method to int but we should use return 
            // and we can also remove the (string[] args) if we want
            // and also we can from the program settings put a value for the args
        }
    }
}
