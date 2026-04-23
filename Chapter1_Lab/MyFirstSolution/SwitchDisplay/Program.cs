namespace SwitchDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();
            value = int.Parse(input);
            switch (value)
            {
                case 1:
                    Console.WriteLine("You entered 1.");
                    break;
                case 2:
                    Console.WriteLine("You entered 2.");
                    break;
                default:
                    Console.WriteLine("The number you entered is not 1 or 2.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
