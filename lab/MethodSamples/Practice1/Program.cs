using System.Globalization;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content = Console.ReadLine().Split(",");
            int max = int.Parse(content[0]);

            for (int i = 1; i < content.Length; i++)
            {
                int current = int.Parse(content[i]);
                if (current > max)
                {
                    max = current
                }
            }
            Console.WriteLine($"最大值：{max}");
            Console.ReadLine();


            //string[] input = Console.ReadLine().Split(',');
            //int max = int.Parse(input[0]);

            //for ( int i = 0; i < input.Length; i++)
            //{
            //    int num = int.Parse(input[i]);

            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //}
            //Console.WriteLine($"最大值：{max}");
        }
    }
}
