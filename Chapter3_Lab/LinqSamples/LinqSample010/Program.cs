namespace LinqSample010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            /* Min, Sum, and Average
            int total = list.Sum((x) => x.Age);
            Console.WriteLine($"年齡的總合為：{total}");
            var minAge = list.Min((x) => x.Age);
            Console.WriteLine($"最小的年齡為：{minAge}");
            var maxAge = list.Max((x) => x.Age);
            Console.WriteLine($"最大的年齡為：{maxAge}");

            int count = list.Count();
            Console.WriteLine($"list 總個數為：{count}");
            int countOfBill = list.Count((x) => x.Name == "Bill");
            Console.WriteLine($"list 中的 Bill 總數量為：{countOfBill}");

            var average = list.Average((x) => x.Age);
            Console.WriteLine($"年齡的平均值為：{average}");
            Min, Sum, and Average */

            /* Min, Sum, and Average 複合查詢
            var min2 = list.Where((x) => x.Name == "Bill").Min((x) => x.Age);
            Console.WriteLine($"所有 Bill 中最小的年齡是：{min2}");
            var total2 = list.Where((x) => x.Name == "Bill").Sum((x) => x.Age);
            Console.WriteLine($"所有 Bill 的年齡總和是：{total2}");
            var average2 = list.Where((x) => x.Name == "Bill").Average((x) => x.Age);
            Console.WriteLine($"所有 Bill 的年齡平均是：{average2}");
            Min, Sum, and Average */

            MyData minObject_before = list.First(x => x.Age == list.Min(x => x.Age));
            Console.WriteLine($"最小的年齡是：{minObject_before.Name}, {minObject_before.Age}");
            MyData minObject_after = list.MinBy((x) => x.Age);
            Console.WriteLine($"最小年齡的人是：{minObject_after.Name}, {minObject_after.Age}");

            MyData maxObject_before = list.First(x => x.Age == list.Min(x => x.Age));
            Console.WriteLine($"最大的年齡是：{maxObject_before.Name}, {maxObject_before.Age}");
            MyData maxObject_after = list.MaxBy((x) => x.Age);
            Console.WriteLine($"最大年齡的人是：{maxObject_after.Name}, {maxObject_after.Age}");

            Console.ReadLine();

            static List<MyData> CreateList()
            {
                return
                [
                    new() { Name = "Bill", Age = 46 },
                new() { Name = "John", Age = 37 },
                new() { Name = "Tom", Age = 48 },
                new() { Name = "David", Age = 36 },
                new() { Name = "Bill", Age = 35 }
                ];
            }
        }
    }
}
