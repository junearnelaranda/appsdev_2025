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
    public partial class FoxFrame : Form
    {
        private string _username;
        public FoxFrame(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/MM1014B-3S?sku=6587",
                UseShellExecute = true
            });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/AU8005N-1A?sku=5938",
                UseShellExecute = true
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/AU2065N-9A?sku=4403",
                UseShellExecute = true
            });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/LB1006G-8A?sku=3936",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/LB1006G-8A?sku=3936",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/NC3015J-0S?sku=5015",
                UseShellExecute = true
            });
        }

        private void hFoxBack_Click(object sender, EventArgs e)
        {
            HeartForm FoxFrame = new HeartForm(_username);
            this.Hide();
            FoxFrame.ShowDialog();
            this.Close();
        }
    }
}
