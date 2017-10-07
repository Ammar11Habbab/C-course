using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lambda_Expression
{
    delegate int mynewnumber(int myxnumber);

    class Program
    {
        static int myxnumber = 3;
        static void Main(string[] args)
        {

            //mynewnumber n = x => x + myxnumber;
            //mynewnumber n2 = x => x * myxnumber;
            //WriteLine($" myxnumber = {n(3)}");
            //WriteLine($" myxnumber = {n2(4)}");
            Func<int, bool> func2 = (x => x % 2 != 0);
            int[] myarray = { 1, 2, 3, 4, 5, 6 };
            for (int i=0; i<myarray.Length; i++)
            {
                WriteLine(func2.Invoke(myarray[i]));
            }
            ReadKey();
        }
    }
}
