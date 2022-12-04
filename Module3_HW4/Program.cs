using Module3_HW4.DelegatesPart;
using Module3_HW4.LINQPart;

namespace Module3_HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Delegates part:");
            Console.ForegroundColor = ConsoleColor.White;
            DelegatesTrainingClass.LocalMain();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nLINQ part:");
            Console.ForegroundColor = ConsoleColor.White;
            LINQTrainingClass.LocalMain();
        }
    }
}