namespace Day2WordsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an English sentence.");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            Console.WriteLine($"{input} has {words.Length} words");
        }
    }
}
