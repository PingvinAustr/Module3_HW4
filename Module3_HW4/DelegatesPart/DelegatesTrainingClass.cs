using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW4.DelegatesPart
{
    public static class DelegatesTrainingClass
    {
        private static int _currentSum;
        public delegate int SumDel(int a, int b);
        public static event SumDel SumDelEvent;

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static void MethodWrapper(SumDel del, int a, int b)
        {
            try
            {
                Console.WriteLine(
                    $"Invoking sum method with parameters {a} and {b}",
                    a,
                    b);
                _currentSum += del.Invoke(a, b);
            }
            catch
            {
                Console.WriteLine(
                    $"\nException occured while" +
                    $"trying to execute {del} with parameters {a} and {b}",
                    del,
                    a,
                    b);
            }
        }

        public static void LocalMain()
        {
            SumDelEvent += Sum;
            SumDelEvent += Sum;

            Random rand = new Random();
            foreach (SumDel del in SumDelEvent.GetInvocationList())
            {
                int a = rand.Next(0, 10);
                int b = rand.Next(0, 10);
                MethodWrapper(del, a, b);
            }

            Console.WriteLine("Total sum = " + _currentSum);
        }
    }
}
