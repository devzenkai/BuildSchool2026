namespace DoWhileLoopSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i = 1;
            do
            {
                result = result + i;
                i = i + 1;
            }
            while (i < 11);
            Console.WriteLine($"sum result: {result}");
            Console.ReadLine();
        }
    }
}
