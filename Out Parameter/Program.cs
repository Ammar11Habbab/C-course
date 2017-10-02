using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameter
{
    class Program
    {
        static int MinValue(int[] myarray2, out int myindex)
        {
            int minval = myarray2[0];
            myindex = 0;
            for (int i = 1; i < myarray2.Length; i++)
            {
                if (myarray2[i] < minval)
                {
                    minval = myarray2[i];
                    myindex = i;
                }
            }
            return minval;
        }
        static void Main(string[] args)
        {
            int myindex;
            int[] myarray = { 11, 10, 6, 24, 51, 22 };
            int minval = MinValue(myarray, out myindex);
            Console.WriteLine($" the minimum value in my array is {minval} and the index is {myindex}");
            Console.ReadKey();

        }
    }
}
