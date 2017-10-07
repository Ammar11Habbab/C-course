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