namespace ListSample004
{
    public partial class Form1 : Form
    {
        private List<string> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();
        }
        private void CreateList()
        {
            _list = new List<string>()
            {
                "Dog", "Cat", "Monkey", "Fly", "Donkey", "Dog2"
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = _list.Find((x) => x == textBox1.Text);
            MessageBox.Show($"Find: {result}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string index = _list.Find((x) => x == textBox1.Text);
            MessageBox.Show($"Find Index: {index}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> results = _list.FindAll((x) => x.Contains(textBox1.Text));
            string result = string.Join(",", results);
            MessageBox.Show($"Fing All: {result}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string result = _list.FindLast((x) => x.Contains(textBox1.Text));
            MessageBox.Show($"Find Last: {result}");
        }
    }
}
