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
    public partial class ovalgeometric : Form
    {
        private string _username;
        public ovalgeometric(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/classico-cc43/",
                UseShellExecute = true
            });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/retra-rt07/",
                UseShellExecute = true
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/hanamoto-h01/",
                UseShellExecute = true
            });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/th/en/products/JD1045Z-4A",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/hanamoto-h06/",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/AU8007N-3A",
                UseShellExecute = true
            });
        }

        private void OvalGeometricBack_Click(object sender, EventArgs e)
        {
            OvalForm ovalgeometric = new OvalForm(_username);
            this.Hide();
            ovalgeometric.ShowDialog();
            this.Close();
        }
    }
}
