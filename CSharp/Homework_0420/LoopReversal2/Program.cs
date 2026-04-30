namespace LoopReversal2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = input; i >= 1; i--)
            {
                for (int j = 0; j < input - i + 1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
