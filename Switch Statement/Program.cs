using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string myanimal = "cat";
            switch (myanimal)
            {
                case "canary":
                    Console.WriteLine("your animal is canary");
                    break;
                case "bird":
                    Console.WriteLine("your animal is cat");
                    break;
                case "dog":
                    Console.WriteLine("your animal is dog");
                    break;
                default:
                    Console.WriteLine("none of them");
                    break;

            }
            Console.ReadKey();


        }
    }
}
