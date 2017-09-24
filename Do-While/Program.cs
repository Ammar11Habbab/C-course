using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {

            double mysalary = 1000.20, total = 0.0;
            int i = 0;
            do
            {

                total += mysalary;
                i++;
                Console.WriteLine(" my value equal {0}", i);


            }
            while (i < 10);
            Console.WriteLine(" my salary equal {0}", total);
            Console.ReadKey();


        }
    }
}
