using System.Linq;
namespace GuessNumber
{
    public partial class Form1 : Form
    {
        private string answer = "";
        public Form1()
        {
            InitializeComponent();
            guessHistory.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameStart.Enabled = true;
            reveal.Enabled = false;
            checkResult.Enabled = false;
            reset.Enabled = false;
        }

        private void gameStart_Click(object sender, EventArgs e)
        {
            gameStart.Enabled = false;
            reveal.Enabled = true;
            checkResult.Enabled = true;
            reset.Enabled = true;
            Random rnd = new Random();
            var digits = Enumerable.Range(0, 10).ToList();
            answer = "";

            for (int i = 0; i < 4; i++)
            {
                int index = rnd.Next(digits.Count);
                answer += digits[index].ToString();
                digits.RemoveAt(index);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            answer = "";
            guessHistory.Text = "";
            gameStart.Enabled = true;
            reveal.Enabled = false;
            checkResult.Enabled = false;
            reset.Enabled = false;
        }
        private void checkResult_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text.Trim();
            if (guess.Length != 4)
            {
                MessageBox.Show("請輸入4位數字");
                return;
            }
            string result = checkAB(guess);

            guessHistory.Text += $"{guess}:{result}{Environment.NewLine}";

            if (result == "4A0B")
            {
                MessageBox.Show("Success!");
            }
        }

        private string checkAB(string guess)
        {
            int A = 0;
            int B = 0;

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == answer[i])
                {
                    A++;
                }
                else if (answer.Contains(guess[i]))
                {
                    B++;
                }
            }
            return $"{A}A{B}B";
        }

        private void reveal_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"答案是：{answer}");
        }
    }
}
