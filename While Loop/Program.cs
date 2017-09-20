using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            double mysalary = 1000.20, total = 0.0;
            while (i < 15)
            {
                total += mysalary;
                i++;

            }
            Console.WriteLine(" my salary after 15 months {0}", total);
            Console.ReadKey();
        }
    }
}
