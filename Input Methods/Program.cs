using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname;
            int myvar1, myvar2;
            Console.WriteLine("\n Enter Your Name \n");
            myname = Console.ReadLine();
            Console.WriteLine("\n Enter Your Number \n");
            myvar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter Your Char \n");
            // read will allow you to put 1 char and it will give you the asky code number of it BUT remember you can 
            // remember you can change that using conversions
            myvar2 = Console.Read();
            Console.WriteLine($"\n Your Name is {myname} \n You Number is {myvar1} \n Your Char ASKY Code is {myvar2}");
            Console.ReadKey();
        }
    }
}
