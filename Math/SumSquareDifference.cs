using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class SumSquareDifference
    {
        public static void RunSumSquareDifference()
        {
            bool option = true;
            while (option)
            {
                Console.Clear();
                SumSquareDiff();
                option = Program.QuitOption();
            }
        }
        public static void SumSquareDiff()
        {
            int check = DisplaySumSquareDiff();
            int sumSquares = SumOfSquares(check);
            int squaresSum = SquareOfSums(check);
            int result = squaresSum - sumSquares;
            Console.WriteLine("Your difference is: " + result);
        }
        public static int DisplaySumSquareDiff()
        {
            Console.WriteLine("Find the difference sum of the squares and the square of sum under a number");
            int check = Convert.ToInt32(Prompt("Enter your Number"));
            return check;
        }
        public static int SumOfSquares(int check)
        {
            int sum = 0;
            for (int index = 1; index <= check; index++)
            {
                sum += index * index;
            }
            return sum;
        }
        public static int SquareOfSums(int check)
        {
            int sum = 0;
            for (int index = 1; index <= check; index++)
            {
                sum += index;
            }
            sum = sum * sum;
            return sum;
        }
        public static string Prompt(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }
    }
}
