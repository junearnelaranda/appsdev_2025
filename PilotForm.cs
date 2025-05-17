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
    public partial class PilotForm : Form
    {
        private string _username;
        public PilotForm(string userName)
        {
            InitializeComponent();
            _username = userName;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/magnus",
                UseShellExecute = true
            });
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/franz",
                UseShellExecute = true
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/cliff",
                UseShellExecute = true
            });
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/bruno",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/tobias",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/chiyo",
                UseShellExecute = true
            });
        }

        private void PilotBack_Click(object sender, EventArgs e)
        {
            RoundForm roundForm = new RoundForm(_username);
            this.Hide();
            roundForm.ShowDialog();
            this.Close();
        }
    }
}
