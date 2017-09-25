using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_array_vs_foreach_array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] myfullname = { "Ammar", "Yaser", "Habbab" };
            int myarraylength = myfullname.Length;
            for (int i = 0; i < myarraylength; i++)
                {
             myfullname[2] = "Hbab";
            // we use forloop if we want to change a value in the array
            Console.Write($"{myfullname[i]}" + " ");

                  }
            Console.WriteLine($"\n{myarraylength}");
            foreach (string myname in myfullname)
            Console.Write($"{myname}" + " ");
            // we cant use foreach if we want to change inside the loop an array value
            Console.ReadKey();
        }
    }
}
