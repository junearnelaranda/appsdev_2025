using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EyeWear
{
    public partial class Home : Form

    {
        private string _username;

        public Home(string username)
        {
            InitializeComponent();
            _username = username;
            label1.Text = "Welcome " + username;
           
            
        }

        private void homeClick_Click(object sender, EventArgs e)
        {
            Home home = new Home(_username);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void shapeClick_Click(object sender, EventArgs e)
        {
            Faces facesForm = new Faces(_username);  // Make sure you created this form
            this.Hide();
            facesForm.ShowDialog();
            this.Close();
        }

        private void contactsClick_Click(object sender, EventArgs e)
        {
            Contacts contactsForm = new Contacts(_username);  // Make sure you created this form
            this.Hide();
            contactsForm.ShowDialog();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Hprofile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(_username);
            this.Hide();
            profile.ShowDialog();
            this.Close();
        }
    }
}
