using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Types_Char_String_Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            int charmin = char.MinValue;
            int charmax = char.MaxValue;
            char myvar = 'A';
            int myvarvalue = 'A';
            char myvarvalue2 = Convert.ToChar(80);



            Console.WriteLine("Min Char = {0} Max Char = {1} my Variable char = {2} my Variable Number {3} my Cnnversion value is = {4}", charmin, charmax, myvar,myvarvalue, myvarvalue2);

            string mystring = "this is my variable ";

            Console.WriteLine("\n my string is {0}",mystring);


            bool mybool = true;
            Console.WriteLine("\n my boolean value is {0}", mybool);
            Console.ReadKey();
        }
    }
}
