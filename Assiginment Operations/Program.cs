using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiginment_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int myvar1 = 7, myvar2 = 3;
            myvar1 %= myvar2;
            Console.WriteLine(" my var 1 result = {0} my var 2 result = {1} ", myvar1, myvar2);
            Console.ReadKey();
        }
    }
}
