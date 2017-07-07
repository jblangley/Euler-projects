using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Math
{
    class DistinctPowers
    {
        public static void RunDistinctPowers()
        {
            bool option = true;
            while (option)
            {
                Console.Clear();
                DistinctPowersM();
                option = Program.QuitOption();
            }
        }
        public static void DistinctPowersM()
        {
            int[] range = new int[2];
            range = CheckRange(range);
            List<int> results = FindDistinctPowers(range);
            SortResults(results);
            DeleteDuplicates(results);
            DisplayDistinctPowersResults(results);
        }
        public static void DisplayDistinctPowersResults(List<int> result)
        {
            string display = " ";
            for (int index = 0; index < result.Count; index++)
            {
                display += Convert.ToString(result[index]);
                if (index < result.Count - 1)
                {
                    display += ", ";
                }
            }
            //Console.WriteLine(display);
            Console.WriteLine("The total number of results is: " + result.Count);
        }
        public static List<int> FindDistinctPowers(int[] range)
        {
            List<int> results = new List<int>();
            Int64 count = 0;
            for (int index = range[0]; index <= range[1]; index++)
            {
                for (int inde = range[0]; inde <= range[1]; inde++)
                {
                    int temp = 1;
                    for (int i = 1; i <= inde; i++)
                    {
                        temp = temp * index;
                    }
                    results.Add(temp);
                    count++;
                }
            }
            Console.WriteLine(count);
            return results;
        }
        public static int[] CheckRange(int[] range)
        {
            range[0] = (Convert.ToInt32(Prompt("Enter the first number of your Range")));
            range[1] = (Convert.ToInt32(Prompt("Enter the second number of your Range")));
            int temp;
            if (range[0] > range[1])
            {
                temp = range[1];
                range[1] = range[0];
                range[0] = temp;
            }
            else if (range[0] == range[1])
            {
                Console.WriteLine("Your range cannot be the same");
                range[0] = (Convert.ToInt32(Prompt("Enter the first number of your Range")));
                range[1] = (Convert.ToInt32(Prompt("Enter the second number of your Range")));
                CheckRange(range);
            }
            return range;
        }
        public static void DeleteDuplicates(List<int> result)
        {
            int temp = result.Count - 1;
            for (int index = 0; index < temp; index++)
            {
                if (result[index] == result[index + 1])
                {
                    result.Remove(result[index]);
                    index--;
                    temp--;
                }
            }
        }
        public static void SortResults(List<int> result)
        {
            int temp;
            for (int index = 0; index <= result.Count - 1; index++)
            {
                for (int sort = 0; sort < result.Count - 1; sort++)
                {

                    if (result[sort] > result[sort + 1])
                    {
                        temp = result[sort];
                        result[sort] = result[sort + 1];
                        result[sort + 1] = temp;
                    }
                }
            }
        }
        public static string Prompt(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }
    }
}
