namespace SequenceReversal2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var result = Enumerable.Range(1, n).Select(i => new string((n - i + 1).ToString()[0], i));

            foreach(var line in result)
            {
                Console.WriteLine(line);
            }
        }
    }
}
