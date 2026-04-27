namespace LinqSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            ////Query Expression
            //IEnumerable<MyData> people =
            //    from data in list
            //    where data.Name == "Bill"
            //    select data;

            //Method Expression
            var people = list.Where((x) => x.Name == "Bill");

            //輸出結果
            foreach (MyData person in people)
            {
                Console.WriteLine($"{person.Name} 是 {person.Age} 歲");
            }
            Console.ReadLine();
        }
        static List<MyData> CreateList()
        {
            return new List<MyData>() //集合初始化設定式
            {
                new MyData{ Name = "Bill", Age = 47 }, //物件初始化設定式
                new MyData{ Name = "John", Age = 37 },
                new MyData{ Name = "Tom", Age = 48 },
                new MyData{ Name = "David", Age = 36 },
                new MyData{ Name = "Bill", Age = 35 }
            };
        }
    }
}
