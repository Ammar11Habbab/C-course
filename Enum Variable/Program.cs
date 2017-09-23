using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Variable
{
    class Program
    {
        enum humansex : sbyte
        {
            male = 1,
            female = 2
        }

        static void Main(string[] args)
        {
            sbyte mysbyte;
            string gender;
            humansex mystrhuman = humansex.male;
            Console.WriteLine($" the gender is {mystrhuman}" + "\n");
            mysbyte = (sbyte)mystrhuman;
            Console.WriteLine($" my index gender number is {mysbyte}" + "\n");
            gender = Convert.ToString(mystrhuman);
            Console.WriteLine($" sex is {gender}" + "\n");
            Console.ReadKey();
        }   
    }
}
