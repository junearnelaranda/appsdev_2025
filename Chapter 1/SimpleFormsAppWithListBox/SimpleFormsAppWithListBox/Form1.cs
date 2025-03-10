namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text) && listBox.Items.Contains(textBox.Text));
            {
                listBox.Items.Add(textBox.Text);            
            }
        }

        private void rmvBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
