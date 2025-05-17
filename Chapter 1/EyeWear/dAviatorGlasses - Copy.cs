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
    public partial class dAviatorGlasses : Form
    {
        private string _username;
        public dAviatorGlasses(string userName)
        {
            InitializeComponent();
            _username = userName;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/levis-ls99027-sunglasses-women-men",
                UseShellExecute = true
            });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-diamond-faces/products/benny",
                UseShellExecute = true
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-diamond-faces/products/chiyo",
                UseShellExecute = true
            });
        }
        

        private void button9_Click(object sender, EventArgs e)

        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/gucci-gg0351s",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-diamond-faces/products/julius",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/stella-mccartney-sc0125o-eyeglasses-women",
                UseShellExecute = true
            });
        }

        private void dAviatorGlasses_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DiamondForm dcateyeGlasses = new DiamondForm(_username);
            this.Hide();
            dcateyeGlasses.ShowDialog();
            this.Close();
        }
    }
}

