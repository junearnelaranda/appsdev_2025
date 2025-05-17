namespace EyeWear
{
    public partial class User : Form
    {
        
        public User()
        {
            InitializeComponent();
            textBox1.KeyDown += textBox1_KeyDown;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string name = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(name))
                {
                    
                    UserData.Username = name;
                    UserData.FirstName = Ufname.Text.Trim(); // Add Ufname textbox if not already
                    UserData.LastName = Ulname.Text.Trim();  // Same here
                    UserData.Email = Uemail.Text.Trim();     // And here

                    Home home = new Home(name);
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter your nickname.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;  // Make sure no control is selected at startup
            Ufname.KeyDown += MoveToNextOnEnter;
            Ulname.KeyDown += MoveToNextOnEnter;
            Uemail.KeyDown += MoveToNextOnEnter;

        }
        private void MoveToNextOnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;  // Prevent the "ding" sound

                TextBox currentTextBox = (TextBox)sender;

                if (string.IsNullOrEmpty(currentTextBox.Text.Trim()))
                {
                    MessageBox.Show("Please fill out the required field.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // If the field is not empty, move to the next control
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
