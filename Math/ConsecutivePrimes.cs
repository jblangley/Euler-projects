using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class ConsecutivePrimes
    {
        public static void RunConsecutivePrimeSum()
        {
            bool option = true;
            while (option)
            {
                Console.Clear();
                ConsecutivePrimeSum();
                option = Program.QuitOption();
            }
        }
        public static void ConsecutivePrimeSum()
        {
            int max = Convert.ToInt32(Prompt("Enter a number to see the largest prime sum of a consecutive primes under that number"));
            List<int> consecs = FindPrimeSumsLoop(max);
            List<int> sums = AddConsecs(consecs, max);
            List<int> primes = FindPrimeSum(sums);
            max = LargestNumber(primes);
            Console.WriteLine("Your largest prime added from consecutive primes is: " + max);
        }
        public static int LargestNumber(List<int> primes)
        {
            int large = 0;
            for (int index = 1; index < primes.Count; index++)
            {
                if (primes[index] > primes[index - 1])
                {
                    large = primes[index];
                }
            }
            return large;
        }
        public static List<int> FindPrimeSum(List<int> sums)
        {
            bool check = false;
            List<int> primesums = new List<int>();
            for (int index = 0; index < sums.Count; index++)
            {
                check = FindPrime(sums[index]);
                AddPrimesToList(check, sums[index], primesums);
            }
            return primesums;
        }
        public static List<int> FindPrimeSumsLoop(int max)
        {
            bool check = false;
            List<int> consecs = new List<int>();
            for (int index = 2; index < max; index++)
            {
                check = FindPrime(index);
                AddPrimesToList(check, index, consecs);
            }
            return consecs;
        }
        public static List<int> AddConsecs(List<int> consecs, int max)
        {

            List<int> sums = new List<int>();
            for (int index = 0; index < consecs.Count; index++)
            {
                if (true == FindPrime(index))
                {
                    int sum = index;
                    for (int ind = index; ind < consecs.Count; ind++)
                    {
                        sum += consecs[ind];
                        if (sum < max)
                        {
                            sums.Add(sum);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return sums;
        }
        public static void AddPrimesToList(bool check, int num, List<int> primes)
        {
            if (check == false)
            {
                primes.Add(num);
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
        public static string Prompt(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }
    }
}
