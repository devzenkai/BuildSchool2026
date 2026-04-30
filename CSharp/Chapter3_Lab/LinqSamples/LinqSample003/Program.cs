using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinqSample003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            /* First & FirstOrDefault
            var person1 = list.FirstOrDefault((x) => x.Age < 37);
            Console.WriteLine($"小於 37 歲第一個被找到的是：{person1.Name}");

            var customDefault = list.FirstOrDefault((x) => x.Age < 30, 
                new MyData { Name = "Not Found", Age = 0 });
            Console.WriteLine($"找不到, 所以回傳自定物件：{customDefault.Name}");

            var person2 = list.First((x) => x.Age < 30);
            Console.Write($"小於 30 歲的人第一個被找到的是：{person2.Name}");
            First & FirstOfDefault */

            /* Last & LastOrDefault
            var person1 = list.LastOrDefault((x) => x.Age > 35);
            Console.WriteLine($"大於 35 歲的人最後一個被找到的是：{person1.Name}");

            var customDefault = list.LastOrDefault((x) => x.Age > 50,
                new MyData { Name = "Not Found", Age = 130 });
            Console.WriteLine($"找不到, 所以回傳自訂物件：{customDefault.Name}");

            var person2 = list.Last((x) => x.Age > 50);
            Console.WriteLine($"大於 50 歲的人最後一個被找到的是：{person2.Name}");
            Last & LastOrDefault */

            /* Single & SingleOrDefault
            var person1 = list.SingleOrDefault((x) => x.Name == "Tom");
            Console.WriteLine($"找到唯一的：{person1.Name}");

            var customDefault = list.SingleOrDefault((x) => x.Name == "Not Found",
                new MyData { Name = "Not Found", Age = 0 });
            Console.WriteLine($"找不到, 所以回傳自訂物件：{customDefault.Name}");

            var person2 = list.Single((x) => x.Name == "Bill");
            Console.WriteLine($"找到唯一的：{person2.Name}");
            Single & SingleOrDefault */

            /* 正確處理預設值
            var person = list.FirstOrDefault((x) => x.Name == "李小龍");
            if (person == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到：{person.Name} - {person.Age}");
            }
            正確處理預設值 */

            /* ElementAt & ElementAtOrDefault
            int index = 1;

            var person = list.ElementAtOrDefault(index);
            if (person == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到索引為：{index} 的人是 {person.Name}");
            }
            ElementAt & ElementAtOrDefault */

            /* Any
            string name = "David";
            bool result = list.Any((x) => x.Name == name);
            if (result)
            {
                Console.WriteLine($"找到了：{name}");
            }
            else
            {
                Console.WriteLine($"找不到：{name}");
            }
            Any */

            /* All
            string name = "Bill";
            bool isAllBill = list.All((x) => x.Name == name);
            if (isAllBill)
            {
                Console.WriteLine($"全都是 {name}");
            }
            else
            {
                Console.WriteLine($"有些人不叫 {name}");
            }
            bool isAllOverForty = list.All((x) => x.Age >= 40);
            if (isAllOverForty)
            {
                Console.WriteLine("大家都超過 40 歲");
            }
            else
            {
                Console.WriteLine("有人不到 40 歲");
            }
            All */
            Console.ReadLine();
        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData{ Name = "Bill", Age = 47 },
                new MyData{ Name = "John", Age = 37 },
                new MyData{ Name = "Tom", Age = 48 },
                new MyData{ Name = "David", Age = 36 },
                new MyData{ Name = "Bill", Age = 35 }
            };
        }
    }
}
