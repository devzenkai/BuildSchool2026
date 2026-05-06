namespace OddAndEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] numbers = input
                .Split(",")
                .Select(s => int.Parse(s.Trim()))
                .ToArray();

            int[] odds = numbers
                .Where(n => n % 2 != 0)
                .OrderBy(n => n)
                .ToArray();

            int[] evens = numbers
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray();

            Console.WriteLine($"Odds: {string.Join(",",odds)}");
            Console.WriteLine($"Evens: {string.Join(",", evens)}");
        }
    }
}
