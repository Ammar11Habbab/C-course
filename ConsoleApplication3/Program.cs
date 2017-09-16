using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //\' \" \0 \a \\ \b \n \r \t \v \f
            //\@
            string mystring = "ammar said this a good course";
            string mystring2 = ", yes it's";
            string mystring3 = mystring + mystring2;
            Console.WriteLine("{0}", mystring3);
            Console.ReadKey();

        } 
    }
}
