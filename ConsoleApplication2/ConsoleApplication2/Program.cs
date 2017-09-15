using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            float minvalue = float.MinValue;
            float maxvalue = float.MaxValue;
            Console.WriteLine("min value = {0} max val = {1}", minvalue, maxvalue);




            float flvar = 1F / 3;
            double dlvar = 1D / 3;
            decimal devar = 1M / 3;
            Console.WriteLine("\nfloat value = {0}\ndouble value = {1}\ndecimal value = {2}", flvar, dlvar, devar);
            Console.ReadKey();    
            



            
        }
    }
}
