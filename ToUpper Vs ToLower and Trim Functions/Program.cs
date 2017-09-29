using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpper_Vs_ToLower_and_Trim_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring, mystring2;
            char[] mytrimchar = { 'h', 'e', 'i', ' ' };
            Console.WriteLine("pleae enter your string");
            mystring = Console.ReadLine();
            mystring = mystring.ToLower();
            mystring2 = mystring.Trim(mytrimchar);
            Console.WriteLine($"{mystring2}");
            Console.ReadKey();
            // trim تخلصنا من الفراغات التي قبل اول كلمة وبعد اخر كلمة وايضا تحذف الحروف التي نعرفها كما فوق
            // tolower تحول جميع الحروف الى صغيرة 
            // toupper تحول جميع الحروف الى كبيرة
        }
    }
}
