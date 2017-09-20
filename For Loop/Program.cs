using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            int mysalary = 1000, total = 0;
            for (int i = 0; i < 12; i++)
            {
                total += mysalary;
            }
            Console.WriteLine(" my own salary is {0}", total);
            Console.ReadKey();
        }
    }
}
