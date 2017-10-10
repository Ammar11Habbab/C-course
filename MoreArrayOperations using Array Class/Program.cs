using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MoreArrayOperations_using_Array_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Working With System Class Libary...");
            //Initialzie Items at Statrtup.
            int[] myarray = new[] { 11, 2, 34, 36, 8 };

            //Array Rank...
            //WriteLine("\n The Rank OF MyArray is = {0} ", myarray.Rank);


            // Print Out Number in A Declared Order
            //WriteLine("Here is The Array");
            //for (int i = myarray.GetLowerBound(1); i <= myarray.GetUpperBound(0); i++)
            //{
            //    // Print A Number
            //    Write(myarray[i] + "\n");

            //}


            //// Sort Them...
            //Array.Sort(myarray);
            //WriteLine("\n\nThe Sorted Array = ");
            //// ...And Print Them.
            //for (int i=0; i <myarray.Length; i++)
            //{
            //    // Print A Number...
            //    Write(myarray[i] + "\n");
            //}


            //// Reverse Them...
            //Array.Reverse(myarray);
            //WriteLine("\n\nThe Reversed Array = ");
            //// ...And Print Them.
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    // Print A Number...
            //    Write(myarray[i] + "\n");
            //}


            // Clear All But...
            //Array.Clear(myarray, 0, myarray.Length);
            //// note the first number is where you want to start from index and the 
            //// second one is for how much numbers you wanna clear
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    // Print A Number
            //    Write(myarray[i] + "\n");
            //}

            // To Transfer An Array From Type To Another Type
            string[] myarray2 = Array.ConvertAll(myarray, element => element.ToString());
            WriteLine(string.Join(";", myarray2));

            ReadKey();

        }
    }
}
