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
    public partial class dRectangularGlasses : Form
    {
        private string _username;
        public dRectangularGlasses(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void dRectangularGlasses_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DiamondForm dRectangularGlasses = new DiamondForm(_username);
            this.Hide();
            dRectangularGlasses.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/agnes-b-abh45011",
                UseShellExecute = true
            });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/bolle-f-megeve-eyeglasses-women",
                UseShellExecute = true
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/bolle-f-montparnasse-eyeglasses-women",
                UseShellExecute = true
            });
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/cacharel-ca0012-001-eyeglasses-women",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/cacharel-ca0013-eyeglasses-women",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/cacharel-ca0015-eyeglasses-kids",
                UseShellExecute = true
            });
        }
    }

}
