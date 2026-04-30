namespace Practice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateArea(5));
            Console.WriteLine(CalculateArea(3, 4));
        }
        static double CalculateArea(double radius) { return Math.Pow(radius, 2) * Math.PI; }
        static double CalculateArea(double height, double weight) { return height * weight; }
    }
}
