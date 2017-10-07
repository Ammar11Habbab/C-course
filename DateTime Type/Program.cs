using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DateTime_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            // WriteLine(DateTime.Now.ToString("hh:mm:ss \nMM: dd: yyyy"));
            //DateTime time = DateTime.Now;
            //string format = "MM/dd/yyyy h:mm:ss";
            //WriteLine(time.ToString(format));

            //DateTime now = DateTime.Now;
            // use space after s to avoid one-char date format
            //string result = now.ToString("s ");
            //WriteLine($"{now} [s] = {result}");
            DateTime now = DateTime.Today;
            for (int i = 0; i < 7; i++)
            {
                WriteLine(now.ToString("dddd"));
                now = now.AddDays(1);
            }


            ReadKey();

 

        }
    }
}
