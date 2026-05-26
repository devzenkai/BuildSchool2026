namespace ContentReplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入 >=90 的數字");
            int max;
            while (true)
            {
                max = int.Parse(Console.ReadLine());
                if (max >= 90)
                {
                    break;
                }
                Console.WriteLine("請輸入 >=90 的數字");
            }
            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("School");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
