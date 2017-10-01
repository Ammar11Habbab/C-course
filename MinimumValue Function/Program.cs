using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumValue_Function
{
    class Program
    {
        static int minvalue(int[] myarray)
        {
            int minval = myarray[0];
            for (int i = 1; i < myarray.Length; i++)
            {
                if (myarray[i] < minval)
                    minval = myarray[i];
            }
            return minval;
        }
        static void Main(string[] args)
        {
            int[] myarray2 = { 11, 10, 2, 4, 6, 8, 9, 22 };
            int minval = minvalue(myarray2);
            Console.WriteLine($" the minvalue is {minval}");
            Console.ReadKey();


        }
    }
}
