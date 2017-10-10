using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    class Program
    {
        public static void PrintValues(string name = "Ammar Habbab", int Number = 8)
        {
            Console.WriteLine($"My Name is {name} And My Number is {Number} ");

        }
        static void Main(string[] args)
        {
            string name = "Maison";
            int Number = 9;
            PrintValues();
            PrintValues(name);
            PrintValues(name, Number);
            PrintValues(name: "Yaser", Number: 4);
            Console.ReadKey();

        }
    }
}
