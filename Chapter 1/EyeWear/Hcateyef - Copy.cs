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
    public partial class Hcateyef : Form
    {
        private string _username;

        public Hcateyef(string username)
        {
            InitializeComponent();
        }

        private void HeartBack_Click(object sender, EventArgs e)
        {
            HeartForm RimlessGlasses = new HeartForm(_username);
            this.Hide();
            RimlessGlasses.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/cat-eye-glasses/products/phoebe",
                UseShellExecute = true
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/cat-eye-glasses/products/kitty",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/cat-eye-glasses/products/greta",
                UseShellExecute = true
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/cat-eye-glasses/products/sylvie",
                UseShellExecute = true
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/cat-eye-glasses/products/lane",
                UseShellExecute = true
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/cat-eye-glasses/products/rowank",
                UseShellExecute = true
            });
        }
    }
}
