using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //  const تستطيع ان تعبر عن الحجم 5 بمتغير لكن هذه الطريقة لا تصلح للطريقة الثالثة الا اذا عرفنا ب  
            // جميع طرائق تعريف المتغير 
            const int myarraysize = 5;
            int[] mynumbers = { 1, 5, 6, 8, 2 };
            int[] mynumbers2 = new int [5];
            int[] mynumbers3 = new int[myarraysize] { 1, 5, 6, 8, 2 };
            for (int i=0; i<5; i++)
            Console.WriteLine($"my numbers" + (i + 1) + "=" + $"{mynumbers[i]}" + " ");
            Console.ReadKey();


        }
    }
}
