using System.Globalization;

namespace OddAndEven2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //user input
            string[] parts = input.Split(","); //split input by using comma

            int[] odd = new int[parts.Length];
            int[] even = new int[parts.Length];
            int oddCount = 0, evenCount = 0;

            for (int i = 0; i < parts.Length; i++)
            {
                int n = int.Parse(parts[i]);
                if (n % 2 == 0)
                {
                    even[evenCount++] = n;
                }
                else
                {
                    odd[oddCount++] = n;
                }
            }
            Console.WriteLine($"Odd numbers: {odd}");
            Console.WriteLine($"Even numbers: {even}");
        }
    }
}
