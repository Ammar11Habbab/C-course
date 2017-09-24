using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Type
{
    class Program
    {
        enum toyoto : byte
        {
            tendra = 1,
            highland = 2,
            camery = 3,
            rav4 = 4
        }
        struct cartype
        {
            public toyoto modelname;
            public double modelyear;
        }
        static void Main(string[] args)
        {
            cartype mycartype;
            int cartype = -1;
            double modelyear;
            Console.WriteLine("1) tendra \n2) highland\n3) camery\n4) rav4");
            do
            {
                Console.WriteLine(" Enter Your Car Type ");
                cartype = Convert.ToInt32(Console.ReadLine());
            }
            while ((cartype < 1) || (cartype > 4));

            Console.WriteLine(" input a modelyear ");
            modelyear = Convert.ToDouble(Console.ReadLine());
            mycartype.modelname = (toyoto)cartype;
            mycartype.modelyear = modelyear;
            Console.WriteLine($" My Car Type is {mycartype.modelname}" + 
            $" and the model year is {mycartype.modelyear}" );
            Console.ReadKey();
        }
    }
}
