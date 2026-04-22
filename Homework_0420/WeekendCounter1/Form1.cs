namespace WeekendCounter1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateWeekend()
        {
            int year = int.Parse(userInput.Text);
            int satCount = 52, sunCount = 52;
            bool isLeap = DateTime.IsLeapYear(year);
            DateTime date = new DateTime(year, 1, 1);
            DayOfWeek start = new DateTime(year, 1, 1).DayOfWeek;

            if (isLeap == false) //不是閏年(多一天) -> 52 週 + 1 天
            {
                if (start == DayOfWeek.Saturday)
                {
                    satCount++;
                }
                else if (start == DayOfWeek.Sunday)
                {
                    sunCount++;
                }
            }
            else //閏年(多兩天) -> 52 週 + 2 天
            {
                if (start == DayOfWeek.Friday)
                {
                    satCount++;
                }
                if (start == DayOfWeek.Saturday)
                {
                    satCount++;
                    sunCount++;
                }
                else if (start == DayOfWeek.Sunday)
                {
                    sunCount++;
                }
            }
            label1.Text = $"Saturday: {satCount} days, Sunday: {sunCount} days";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            CalculateWeekend();
        }
    }
}
