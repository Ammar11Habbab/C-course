using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Function_with_String_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring;
            char[] seperator = { 'u',' ' };
            mystring = Console.ReadLine();
            string[] mynewwords;
            mynewwords = mystring.Split(seperator);
            foreach (string word in mynewwords)
            {
                Console.WriteLine($"{word}");
            }
            Console.ReadKey();
        }
    }
}