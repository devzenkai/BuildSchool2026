namespace LoopReversal1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(",");

            string output = "";
            for (int i = parts.Length - 1; i >= 0; i--)
            {
                output = output + parts[i];
                if (i > 0)
                {
                    output = output + ",";
                }
            }
            Console.WriteLine($"Output: {output}");
        }
    }
}
