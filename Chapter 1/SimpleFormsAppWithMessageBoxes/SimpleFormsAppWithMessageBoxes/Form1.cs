namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string  fnameValue = firstName.Text;
            string  lnameValue = lastName.Text;
            string  mnameValue = middleName.Text;
            string  snameValue = suffixName.Text;

        DialogResult result =  MessageBox.Show("Are you sure you want to submit?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Hello There!, {fnameValue} {lnameValue} {mnameValue}, {snameValue}", "Greeetings", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        
        }
    }
}
