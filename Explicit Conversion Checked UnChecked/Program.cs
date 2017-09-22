using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion_Checked_UnChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            int myintvar1 = 350;
            byte mybytevar1;

            mybytevar1 = checked((byte)myintvar1);
            // we use checked to check if there is an overflow
            // unchecked we use it if the setting in visual studio to always check overflow used
            Console.WriteLine($"{myintvar1} \n {mybytevar1}");
            Console.ReadKey();
        }
    }
}
