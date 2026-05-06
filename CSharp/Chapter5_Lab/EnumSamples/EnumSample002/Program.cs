namespace EnumSample002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Authority authority = Authority.Read | Authority.Write;
            Console.WriteLine(authority.HasFlag(Authority.Read));
            Console.WriteLine(authority.HasFlag(Authority.Read | Authority.Write));
            Console.WriteLine(authority.HasFlag(Authority.Read | Authority.Write | Authority.Create));

            Console.WriteLine(authority.HasFlag(Authority.None));
            Console.WriteLine(authority == Authority.None);
            Console.ReadLine();
        }
    }
}
