namespace ProgressiveTaxRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal income = decimal.Parse(Console.ReadLine());
            decimal tax = CalculateTax(income);
            Console.WriteLine($"應繳稅額：{tax}");
        }

        static decimal CalculateTax(decimal income)
        {
            decimal tax = 0m;

            for (int i = 0; i < limits.Length; i++)
            {
                if (income > limits[i])
                {
                    tax += (income - limits[i]) * taxRates[i];
                    income = limits[i];
                }
            }
            tax += income * 0.05m;

            return tax;
        }

        static decimal[] limits =
        {
            10310000m,
            4530000m,
            2420000m,
            1210000m,
            540000m,
        };

        static decimal[] taxRates = {
            0.50m,
            0.40m,
            0.30m,
            0.20m,
            0.12m,
            //0.05m,
        };
    }
}
