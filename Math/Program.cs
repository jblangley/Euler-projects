using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        public static void Run()
        {
            string option = "1";
            while (Convert.ToInt32(option) < 8)
            {
                option = DisplayRunOptions();
                switch (option)
                {
                    case "1":
                        PrimeFinding.RunFindPrime();
                        break;
                    case "2":
                        DistinctPowers.RunDistinctPowers();
                        break;
                    case "3":
                        ConsecutivePrimes.RunConsecutivePrimeSum();
                        break;
                    case "4":
                        Fibonacci.RunEvenFibonacciSum();
                        break;
                    case "5":
                        SumSquareDifference.RunSumSquareDifference();
                        break;
                    case "6":
                        SmallestMultiple.RunSmallestMultiple();
                        break;
                    case "7":
                        ProductInGrid.RunLargestProductInGrid();
                        break;
                    default:
                        break;
                }
            }
        }
        public static string DisplayRunOptions()
        {
            Console.Clear();
            Console.WriteLine("1 - Check Prime");
            Console.WriteLine("2 - Check Range of Distict Powers");
            Console.WriteLine("3 - Consecutive Prime Sum");
            Console.WriteLine("4 - Find the Sum of Even Fibonacci Numbers");
            Console.WriteLine("5 - Find the Sum Square Difference");
            Console.WriteLine("6 - Find the Smallest Multiple");
            Console.WriteLine("7 - Find The Lagest Product in a Grid");
            Console.WriteLine("8 - Exit");
            string read = Console.ReadLine();
            return read;
        }
        public static bool QuitOption()
        {
            string option = DisplayQuitOption();
            if (option == "2")
            {
                return false;
            }
            return true;
        }
        public static string DisplayQuitOption()
        {
            Console.WriteLine("\n\nDo you want to check another number?");
            Console.WriteLine("Enter 1 to continue");
            Console.WriteLine("Enter 2 to go back");
            string option = Console.ReadLine();
            return option;
        }
        public static string Prompt(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }
    }
}
