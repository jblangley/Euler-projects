using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class SmallestMultiple
    {
        public static void RunSmallestMultiple()
        {
            bool option = true;
            while (option)
            {
                Console.Clear();
                SmallMulti();
                option = Program.QuitOption();
            }
        }
        public static void SmallMulti()
        {
            int check = DisplaySmallestMultiple();
            int result = FindMultiples(check);
            Console.WriteLine("Your result is: " + result);
        }
        public static int DisplaySmallestMultiple()
        {
            Console.WriteLine("Find the smallest multiple from one to a particular number.");
            int check = Convert.ToInt32(Prompt("Enter your Number"));
            return check;
        }
        public static int FindMultiples(int check)
        {
            int result = check;
            for (int index = check; index >= 1; index--)
            {
                if (result%index != 0)
                {
                    result++;
                    index = check;
                }
            }
            return result;
        }
        public static string Prompt(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }
    }
}
