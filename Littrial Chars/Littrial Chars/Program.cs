using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Types_Char_String_Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar = -100;
            uint mycar = 1000u;
            long mydar = 100L;
            ulong myulong = 200;
            float myfloat = 1.5F;
            double mydoub = 105.5d;
            decimal mydec = 1005.3M;
            Console.WriteLine(" {0} {1} {2}", myvar, mycar, mydar);
            Console.WriteLine($"{myfloat},{mydoub},{mydec}");
            Console.ReadKey();

        }
    }
}
