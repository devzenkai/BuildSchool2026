namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label_result.Text = "結果：";
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            //if(!radioButton_CtoF.Checked && !radioButton_FtoC.Checked)
            //{
            //    label_result.Text = "Please choose the conversion type.";
            //    return;
            //}

            if (radioButton_CtoF.Checked)
            {
                float celsius = float.Parse(textBox1.Text);
                float fahtrnheit = (celsius * 9 / 5) + 32;
                label_result.Text = $"結果：{celsius}°C = {fahtrnheit}°F";
            }
            else if (radioButton_FtoC.Checked)
            {
                float fahrenheit = float.Parse(textBox1.Text);
                float celsius = (fahrenheit - 32) * 5 / 9;
                label_result.Text = $"結果：{fahrenheit}°F = {celsius}°C";
            }
        }
    }
}
