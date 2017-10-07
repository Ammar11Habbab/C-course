using static System.Console;
using OB = Brothers.MyBrothers.OldBrothers;
using YB = Brothers.MyBrothers.YoungBrothers;


namespace Using_Namespaces_in_Practical
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Those Are My Famliy");
            OB.print();
            YB.print();
            ReadKey();
        }
    }
}
namespace Brothers
{
    namespace MyBrothers
    {
        class OldBrothers
        {
            public static void print()
            {
                Write("Dina " + "And " + "Zeina" );

            }

        }

    }
    namespace MyBrothers
    {
        class YoungBrothers

        {
            public static void print()
            {
                Write("\n" + "Saria " + "And " + "Ibrahim ");
            }

        }

    }
}