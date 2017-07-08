using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Fibonacci
    {
        public static void RunEvenFibonacciSum()
        {
            bool option = true;
            while (option)
            {
                Console.Clear();
                EvenFibonacciSum();
                option = Program.QuitOption();
            }
        }
        public static void EvenFibonacciSum()
        {
            int check = DisplayEvenFibonacciSum();
            List<int> fib = FibSeq(check);
            List<int> evens = FindEvens(fib);
            int sum = SumList(evens);
            Console.WriteLine("Your sum is: " + sum);
        }
        public static int DisplayEvenFibonacciSum()
        {
            Console.WriteLine("Find the sum of even numbers in the Fibonacci Sequence under a particular number.");
            int check = Convert.ToInt32(Prompt("Enter your Number"));
            return check;
        }
        public static List<int> FibSeq(int check)
        {
            List<int> fib = new List<int>();
            fib.Add(1);
            fib.Add(2);
            int temp = 0;
            for (int index = 0; temp <= check; index++)
            {
                temp = fib[index] + fib[index + 1];
                if (temp<check)
                {
                    fib.Add(temp);
                }
            }
            return fib;
        }
        public static List<int> FindEvens(List<int> org)
        {
            List<int> evens = new List<int>();
            for (int index = 0; index < org.Count; index++)
            {
                if (org[index]%2==0)
                {
                    evens.Add(org[index]);
                }
            }
            return evens;
        }
        public static int SumList(List<int> org)
        {
            int sum = 0;
            for (int index = 0; index < org.Count; index++)
            {
                sum += org[index];
            }
            return sum;
        }
        public static string Prompt(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }
    }
}
