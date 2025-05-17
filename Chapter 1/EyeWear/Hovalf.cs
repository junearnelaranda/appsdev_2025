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
    public partial class Hovalf : Form
    {
        private string _username;

        public Hovalf(string username)
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/products/readers-oval-1?variant=40784802283574",
                UseShellExecute = true
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/products/readers-oval-2?variant=43303529021494",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/AU2057T-9S?sku=4159",
                UseShellExecute = true
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/OR1050T-1A",
                UseShellExecute = true
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/OR1050T-1A",
                UseShellExecute = true
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/OR1059M-4A?sku=8308",
                UseShellExecute = true
            });
        }
    }
}
