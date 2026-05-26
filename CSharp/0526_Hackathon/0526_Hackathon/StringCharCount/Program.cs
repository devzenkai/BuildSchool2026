namespace StringCharCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            var words = input
                .Select(w => w.ToLower())
                .GroupBy(w => w)
                .ToDictionary(g => g.Key, g => g.Count());

            foreach (var text in words)
            {
                Console.WriteLine($"{text.Key}: {text.Value}");
            }
        }
    }
}
