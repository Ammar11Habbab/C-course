using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Loop____Continue_Command__
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Hello Ammar");
                if (i > 2)
                    continue;
                for (int j = 0; j <= 3; j++)
                {
                    Console.WriteLine("\t Hello World");
                }
            }
            Console.ReadKey();
        }
    }
}
