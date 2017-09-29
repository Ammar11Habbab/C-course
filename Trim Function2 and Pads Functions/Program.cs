using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim_Function2_and_Pads_Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            string mystring, mystring2;
            char[] mytrimchar = { 'h', 'e', 'i', ' ' };
            Console.WriteLine("pleae enter your string");
            mystring = Console.ReadLine();
            mystring = mystring.ToLower();
            mystring2 = mystring.TrimStart(mytrimchar);
            Console.WriteLine($"{mystring2}");
            mystring2 = mystring.TrimEnd(mytrimchar);
            Console.WriteLine($"{mystring2}");

            mystring2 = mystring.PadLeft(25, '-');
            Console.WriteLine($"{mystring2}");
            mystring2 = mystring.PadRight(25, '-');
            Console.WriteLine($"{mystring2}");
        }
    }
}
