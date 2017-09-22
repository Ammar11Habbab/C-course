using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion__Another_Command_
{
    class Program
    {
        static void Main(string[] args)
        {
            double myvar1 = 2500.20d;
            string mystr1, mystr2;
            // to make an explicit conversion in another command and you can put mystr1 and put conver to integer is should be the same varibles
            mystr1 = Convert.ToString(myvar1);
            // we use it to cut from numbers by substring command mystr2 = mystr1.Substring(0, 2);
            mystr2 = mystr1.Substring(0, 2);
            Console.WriteLine($"{myvar1}\n{mystr1}\n{mystr2}");
            Console.ReadKey();
        }
    }
}
