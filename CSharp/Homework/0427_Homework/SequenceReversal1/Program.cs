namespace SequenceReversal1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var result = string.Join(",", input.Split(",").Reverse());
            Console.WriteLine(result);
        }
    }
}
