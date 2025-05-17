using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeWear
{
    public partial class Profile : Form
    {
        private string _username;
        public Profile(string username)
        {
            InitializeComponent();
            _username = username;
        }
        private void Profile_Load(object sender, EventArgs e)
        {

            Lfname.Text = UserData.FirstName;
            Llname.Text = UserData.LastName;
            Lemail.Text = UserData.Email;

        }

        private void Phome_Click(object sender, EventArgs e)
        {
            Home home = new Home(_username);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void Pshape_Click(object sender, EventArgs e)
        {
            Faces facesForm = new Faces(_username);  // Make sure you created this form
            this.Hide();
            facesForm.ShowDialog();
            this.Close();
        }

        private void Pcontacts_Click(object sender, EventArgs e)
        {
            Contacts contactsForm = new Contacts(_username);  // Make sure you created this form
            this.Hide();
            contactsForm.ShowDialog();
            this.Close();
        }
    }
}
