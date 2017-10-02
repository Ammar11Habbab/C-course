using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_values
{
    class Program
    {
        static void multiplynum(ref int myvar)
        {
            myvar *= 3;
            Console.WriteLine($" my number is {myvar}");
        }
        static void Main(string[] args)
        {
            int mynumber = 5;
            Console.WriteLine($" my number is {mynumber}");
            multiplynum(ref mynumber);
            Console.WriteLine($" my number is {mynumber}");
            Console.ReadKey();
            // نضع ref لان دالة المين لا تغير قيمة المتغير مع اننا غيرناها في الدالة 
        }
    }
}
