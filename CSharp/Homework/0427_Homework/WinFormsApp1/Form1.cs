namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> _leftlist;
        private List<string> _rightlist;

        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetSelectionMode();
            ChangeData();
        }
        private void CreateList()
        {
            _leftlist = new List<string> { "農夫", "狼", "羊", "菜" };
            _rightlist = new List<string>();
        }

        private void SetSelectionMode()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }

        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftlist;
            listBox2.DataSource = _rightlist;
        }

        private void Reset()
        {
            CreateList();
            ChangeData();
        }

        private bool IsWin()
        {
            return _leftlist.Count == 0;
        }

        private bool IsDangerous(List<string> side)
        {
            if (side.Contains("農夫"))
                return false;
            if (side.Contains("狼") && side.Contains("羊"))
                return true;
            if (side.Contains("羊") && side.Contains("菜"))
                return true;
            return false;
        }

        private bool Move(List<string> from, List<string> to, string selectedItem)
        {
            if (!from.Contains("農夫"))
            {
                MessageBox.Show("error");
                return false;
            }

            from.Remove("農夫");
            to.Add("農夫");

            if (selectedItem != null)
            {
                from.Remove(selectedItem);
                to.Add(selectedItem);
            }

            return true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string item = (string)listBox1.SelectedItem;
            if (item == "農夫") item = null;

            if (!Move(_leftlist, _rightlist, item)) return; ChangeData();
            if (IsDangerous(_leftlist))
            {
                MessageBox.Show("Game failed.");
                return;
            }
            if (IsWin())
            {
                MessageBox.Show("Success!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string item = (string)listBox2.SelectedItem;
            if (item == "農夫") item = null;

            if (!Move(_rightlist, _leftlist, item)) return; ChangeData();

            if (IsDangerous(_rightlist))
            {
                MessageBox.Show("Game failed.");
                return;
            }
            if (IsWin())
            {
                MessageBox.Show("Success!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
