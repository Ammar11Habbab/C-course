using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Keyword
{
    class Program
    {
        static double calculate(params double[] values)
        {
            Console.WriteLine("You Sent Me {0} doubles", values.Length);
            double sum = 0;
            if (values.Length== 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return (sum / values.Length);
        }
        static void Main(string[] args)
        {
            double average;
            average = calculate(4.0, 3.2, 5.7, 64.22, 87, 2);
            Console.WriteLine("Average of data is: {0}", average);

            double[] data = { 4.0, 3.2, 5.7 };
            average = calculate(data);
            Console.WriteLine("Average of data is: {0}", average);
            Console.WriteLine();

            Console.WriteLine("Average of data is: {0}", calculate());
            Console.ReadKey();
        }
    }
}
