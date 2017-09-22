using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // carefull not to make a mistake and get into overflow state
            int myintvar = 7;
            byte mybytevar;
            mybytevar = (byte)myintvar;
            Console.WriteLine($"my int variable = {myintvar}" + "\n");
            Console.WriteLine($"my bytevar = {mybytevar}" + "\n");
            Console.ReadKey();
        }
    }
}
