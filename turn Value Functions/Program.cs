using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turn_Value_Functions
{
    class Program
    {
        static void mynumbers(int myfristnumber, int mysecondnumber)
        {
            int temp = myfristnumber + mysecondnumber;
            Console.WriteLine($"{temp}");
        }
        static int mynumbers2(int myfristnumber, int mysecondnumber)
        {
            int temp = myfristnumber + mysecondnumber;
            return temp;
        }
        static void Main(string[] args)
        {
            int myvar1 = 5, myvar2 = 3, temp;
            mynumbers(myvar1, myvar2);
            temp = mynumbers2(myvar1, myvar2);
            Console.WriteLine($"{temp}");
            Console.ReadKey();
        }
    }
}
