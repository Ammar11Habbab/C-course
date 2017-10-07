using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = null;
            int? myint = null;
            WriteLine($"{mystring}");
            WriteLine($"{myint}");
            ReadKey();
        }
    }
}
