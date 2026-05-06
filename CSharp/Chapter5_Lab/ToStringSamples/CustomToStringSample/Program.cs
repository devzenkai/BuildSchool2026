namespace CustomToStringSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rect = new MyRectangle { Width = 100, Height = 100 };
            Console.WriteLine(rect.ToString());
            Console.ReadLine();
        }
    }
}
