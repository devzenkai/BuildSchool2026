namespace LinqSample013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var list2 = new List<int> { 1, 3, 4, 5, 7, 9 };

            var union = list1.Union(list2);
            Console.WriteLine("聯集的結果為：");
            foreach(var item in union)
            {
                Console.WriteLine(item);
            }

            var intersect = list1.Intersect(list2);
            Console.WriteLine("交集的結果為：");
            foreach(var item in intersect)
            {
                Console.WriteLine(item);
            }

            var aEXb = list1.Except(list2);
            Console.WriteLine("A 差集 B 的結果為：");
            foreach(var item in aEXb)
            {
                Console.WriteLine(item);
            }

            var bEXa = list2.Except(list1);
            Console.WriteLine("B 差集 A 的結果為：");
            foreach (var item in bEXa)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
