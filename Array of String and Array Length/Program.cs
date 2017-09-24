using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_String_and_Array_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myfullname = { "Ammar", "Yaser", "Habbab" };
            int mystringlength = myfullname.Length;
            for(int i=0; i < mystringlength; i++)
            {

                Console.Write($"{myfullname[i]}" + " ");
            }
            Console.WriteLine("\nMy Array Length is " + $"{mystringlength}");
            Console.ReadKey();
        }
    }
}
