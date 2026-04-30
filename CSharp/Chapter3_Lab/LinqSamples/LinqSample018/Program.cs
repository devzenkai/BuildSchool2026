namespace LinqSample018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var list = CreateList();
            var result = list.GroupBy((x) => x.City);
            */

            var list = CreateList();
            var result =
            from o in list
            group o by o.City into gp
            select gp;

            foreach (var item in result)
            {
                Console.WriteLine($"住在：{item.Key}");
                foreach(var p in item)
                {
                    Console.WriteLine(p.Name);
                }
                Console.WriteLine("-------");
            }
            Console.ReadLine();
        }
        static List<MyData> CreateList()
        {
            return
            [
                new() { Name = "Bill", City = "Taipei" },
                new() { Name = "John", City = "Taipei" },
                new() { Name = "Tom", City = "Kaohsiung" },
                new() { Name = "David", City = "Tainan" },
                new() { Name = "Jeff", City = "Tainan" },
            ];
        }
    }
}
