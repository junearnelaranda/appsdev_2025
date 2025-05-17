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
    public partial class RectangleForm : Form
    {
        private string _username;
        public RectangleForm(string userName)
        {
            InitializeComponent();
            _username = userName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/bart",
                UseShellExecute = true
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/ernest",
                UseShellExecute = true
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/spencer",
                UseShellExecute = true
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/arlo-1",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/arlo",
                UseShellExecute = true
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/neal",
                UseShellExecute = true
            });
        }

        private void RectangleBack_Click(object sender, EventArgs e)
        {
            RoundForm roundForm = new RoundForm(_username);
            this.Hide();
            roundForm.ShowDialog();
            this.Close();
        }
    }
}
