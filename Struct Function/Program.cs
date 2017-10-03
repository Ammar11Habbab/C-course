using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Function
{
    class Program
    {
        struct myfullnmae
        {
            public string myfirstname, mylastname;
            public string printname() => myfirstname + " " + mylastname;
            // we use it instead of writing Console.Write($"{myfullname.myfirstname} {myfullname.mylastname}" );
        }
        static void Main(string[] args)
        {
            myfullnmae myfullname;
            myfullname.myfirstname = "Ammar";
            myfullname.mylastname = "Habbab";
            // Console.Write($"{myfullname.myfirstname} {myfullname.mylastname}" );
            Console.Write(myfullname.printname());
            Console.ReadKey();

        }
    }
}
