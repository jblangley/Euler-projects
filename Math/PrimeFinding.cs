using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class PrimeFinding
    {
        public static void RunFindPrime()
        {
            bool option = true;
            while (option)
            {
                Console.Clear();
                bool check = FindPrime(Convert.ToInt32(Prompt("Check to see if your number is prime")));
                IsPrime(check);
                option = Program.QuitOption();
            }
        }
        public static bool FindPrime(int num)
        {
            if (num > 2)
            {
                for (int index = 2; index < num; index++)
                {
                    if ((num % index) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void IsPrime(bool check)
        {
            if (check == false)
            {
                Console.WriteLine("This number is a Prime number");
            }
            else
            {
                Console.WriteLine("This number is not a Prime number");
            }
        }
        public static string Prompt(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }
    }
}
