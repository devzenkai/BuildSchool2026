namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ROCEra = int.Parse(Console.ReadLine());
            int CommonEra = ROCEra + 1911;

            bool isLeap = DateTime.IsLeapYear(CommonEra);
            //Console.WriteLine($"民國 {ROCEra} 年 ({CommonEra}）{(isLeap ? "is" : "is not")} leap year.");
            if (isLeap == true)
            {
                Console.WriteLine($"民國 {ROCEra} 年 ({CommonEra}）is leap year.");
            }
            else
            {
                Console.WriteLine($"民國 {ROCEra} 年 ({CommonEra}）is not leap year.");
            }
        }
    }
}
