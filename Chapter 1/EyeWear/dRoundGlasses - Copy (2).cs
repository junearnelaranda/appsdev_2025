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
    public partial class dRoundGlasses : Form
    {
        private string _username;
        public dRoundGlasses(string userName)
        {
            InitializeComponent();
            _username = userName;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/agnes-b-ab47006 ",
                UseShellExecute = true
            });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/furla-vfu297k",
                UseShellExecute = true
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/gucci-gg0348o",
                UseShellExecute = true
            });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/agnes-b-ab60033",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/vfu355-07t1",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/furla-vfu358",
                UseShellExecute = true
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DiamondForm droundGlasses = new DiamondForm(_username);
            this.Hide();
            droundGlasses.ShowDialog();
            this.Close();
        }
    }
}
