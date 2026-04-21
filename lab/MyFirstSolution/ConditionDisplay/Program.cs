namespace ConditionDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int condition = 10;
            int value;
            Console.WriteLine("Please enter a value: ");
            string input = Console.ReadLine();
            value = int.Parse(input);
            if (value > condition)
            {
                Console.WriteLine($"The value {value} is greater than {condition}");
            }
            else if (value < condition)
            {
                Console.WriteLine($"The value {value} is lower than {condition}");
            }
            else
            {
                Console.WriteLine($"The value {value} is equal to {condition}");
            }
        }
    }
}