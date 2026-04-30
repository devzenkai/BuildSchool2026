using System.Globalization;

namespace LinqSample015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list =
                new List<string> { "Taipei", "Taipei", "Los Angeles", "New York", "New York", "Taipei" };
            var result = list.Distinct();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
