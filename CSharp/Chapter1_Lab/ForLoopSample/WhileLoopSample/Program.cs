namespace WhileLoopSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i = 1;
            while (i < 11)
            {
                result = result + i;
                i = i + 1;
                /* 
                 * 也可以寫成
                 * i++ or ++i or i += 1
                 */
            }
            Console.WriteLine($"sum result: {result}");
            Console.ReadLine();
        }
    }
}
