namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void Calculate(Func<int, int, int> result)
        //{
        //    int x = int.Parse(textBox1.Text);
        //    int y = int.Parse(textBox2.Text);
        //    label1.Text = result(x, y).ToString();
        //}

        private void DisplayResult(bool isAdd)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            if (isAdd)
            {
                label1.Text = (x + y).ToString();
                return;
            }
            label1.Text = (x - y).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayResult(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayResult(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
