namespace LabMyPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //型別 變數名稱
            Person p = new Person
            {
                Name = "Andy",
                Height = 165,
                Weight = 70
            };

            //double bmi = p.GetBMI();
            //Console.WriteLine($"{p.Name}'s BMI：{bmi}");
            p.ShowBMI();
        }
    }

    public class Person
    {
        public string Name { get; set; } //屬性
        public double Height { get; set; }
        public double Weight { get; set; }

        public double GetBMI()
        {
            return Weight / Math.Pow(Height / 100, 2);
        }

        public void ShowBMI()
        {
            Console.WriteLine($"{Name}'s BMI：{GetBMI()}");
        }
    }
}
