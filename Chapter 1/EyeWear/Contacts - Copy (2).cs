using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EyeWear
{
    public partial class Contacts : Form
    {
        private string _username;
        public Contacts(string userName)
        {
            InitializeComponent();
            _username = userName;

        }

        private void homeClick2_Click(object sender, EventArgs e)
        {
            Home home = new Home(_username); // Pass the username again
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void shapeClick2_Click(object sender, EventArgs e)
        {
            Faces facesForm = new Faces(_username);  // Make sure you created this form
            this.Hide();
            facesForm.ShowDialog();
            this.Close();
        }

        private void contactsClick2_Click(object sender, EventArgs e)
        {
            Contacts contactsForm = new Contacts(_username);  // Make sure you created this form
            this.Hide();
            contactsForm.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void OjoLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/",
                UseShellExecute = true
            });
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void SunnyLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/",
                UseShellExecute = true
            });
        }

        private void Cprofile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(_username);
            this.Hide();
            profile.ShowDialog();
            this.Close();
        }

        private void eoLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.eo-executiveoptical.com/",
                UseShellExecute = true
            });
        }

        private void ownLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/",
                UseShellExecute = true
            });
        }

        private void idealLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/",
                UseShellExecute = true
            }); 
        }
    }

}