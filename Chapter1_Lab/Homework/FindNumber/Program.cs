namespace Day2JudgeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int num = 1; num < 51; num++)
            {
                if(num % 3 != 0 && num % 5 != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
