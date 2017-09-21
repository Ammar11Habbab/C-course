using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Loop__Break_Command_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Hello Ammar");
                if (i > 2)
                    break;
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Hello Syria");
                }
}
            Console.ReadKey();
        }
    }
}
