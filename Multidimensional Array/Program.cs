using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {


            //int[,] mynumbers = {
            //    {1, 2 ,3 },
            //    {2, 3 ,4 },
            //    {3, 4 ,5 }
            //    };
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{mynumbers[i, j]}" + " ");

            //    }
            //    Console.WriteLine(" ");
            //}
            //Console.ReadKey();


            int[,,] mynumbers2 = new int[2, 2, 3]
                {
                    {
                                    {1, 2, 3 }, {4, 5, 6 }
                    },
                     {
                        {7, 8 ,9 }, {10, 11, 12 }
                     },
                };
            // Console.WriteLine($"{mynumbers2[1,1,2]}");   
            for (int q = 0; q < 2; q++)
            {
                for (int w = 0; w < 2; w++)
                {
                    for (int e = 0; e < 3; e++)
                    {
                        Console.Write($"{mynumbers2[q,w,e]}" + " ");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();

        }
    }
}
 