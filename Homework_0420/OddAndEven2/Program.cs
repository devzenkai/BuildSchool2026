using System.Globalization;

namespace OddAndEven2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //user input
            string[] numbers = input.Split(","); //split input by using comma

            //判斷奇偶數後加入其對應的陣列
            int oddCount = 0, evenCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int n = int.Parse(numbers[i]);
                if (n % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            //新增空的奇數和偶數的陣列
            int[] oddArray = new int[oddCount];
            int[] evenArray = new int[evenCount];
            int odd = 0, even = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int n = int.Parse(numbers[i]);
                if (n % 2 == 0)
                {
                    evenArray[even++] = n;
                }
                else
                {
                    oddArray[odd++] = n;
                }
            }
            Array.Sort(oddArray);
            Array.Sort(evenArray);
            Console.WriteLine($"Odd numbers: {string.Join(",",oddArray)}");
            Console.WriteLine($"Even numbers: {string.Join(",", evenArray)}");
        }
    }
}
