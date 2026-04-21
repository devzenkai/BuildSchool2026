namespace Day2CalcNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numArr = new int[10];
            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    foreach (char c in input)
            //    {
            //        int myNum = int.Parse(c.ToString());
            //        if (myNum == i)
            //        {
            //            numArr[i]++;
            //        }
            //    }
            //}

            //for (int idx = 0; idx < numArr.Length; idx++)
            //{
            //    Console.WriteLine($"數字{idx}：出現{numArr[idx]}次");
            //}

            foreach(char c in input)
            {
                int idx = int.Parse(c.ToString());
                numArr[idx]++;
            }
            for (int idx = 0; idx < numArr.Length; idx++)
            {
                Console.WriteLine($"數字{idx}：出現{numArr[idx]}次");
            }
        }
    }
}
