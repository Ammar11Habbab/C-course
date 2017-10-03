using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Type
{
    delegate int mynewnumber(int mynumber);
    class Program
    {
        static int myxnumber=3;
        static int addfunct(int number)
        {
            myxnumber += number;
            return myxnumber;
        }
        static int mulfunct(int number)
        {
            myxnumber *= number;
            return myxnumber;
        }
        static void Main(string[] args)
        {
            mynewnumber n1 = new mynewnumber(addfunct);
            mynewnumber n2 = new mynewnumber(mulfunct);
            n1(4);
            Console.WriteLine($"{myxnumber}\n");
            n2(5);
            Console.WriteLine($"{myxnumber}");
            Console.ReadKey();
            // we use delegate to shortcut the functions summoning and to point on the paramaters
        }
    }
}
