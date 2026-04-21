using System.Globalization;

namespace Day2SortNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers(seperate with comma(,))");
            string input = Console.ReadLine();
            string[] numStrs = input.Split(',');

            int[] numArr = new int[numStrs.Length];
            for (int i = 0; i < numStrs.Length; i++)
            {
                numArr[i] = int.Parse(numStrs[i]);
            }

            Array.Sort(numArr);

            //foreach (int item in numArr)
            //{
            //    Console.WriteLine(item);
            //}

            string result = string.Join(",", numArr);
            Console.WriteLine(result);
        }
    }
}
