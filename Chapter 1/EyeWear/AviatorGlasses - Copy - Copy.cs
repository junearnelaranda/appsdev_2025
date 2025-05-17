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
    public partial class AviatorGlasses : Form
    {
        private string _username;
        public AviatorGlasses(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.eo-executiveoptical.com/product/eo-herme-studio-hs24907-frame-with-non-graded-free-multicoated-lens-eyeglasses-for-men-and-women/",
                UseShellExecute = true
            });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.eo-executiveoptical.com/product/eo-instyle-in22028-frame-only/",
                UseShellExecute = true
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.eo-executiveoptical.com/product/eo-eyewear-gamma/",
                UseShellExecute = true
            });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.eo-executiveoptical.com/product/eo-herme-studio-hs21029-frame-with-non-graded-free-multicoated-lens-eyeglasses-for-men-and-women/",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.eo-executiveoptical.com/product/eo-blaze-bl2101-eyeglasses/",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.eo-executiveoptical.com/product/eo-blaze-bl2101-eyeglasses/",
                UseShellExecute = true
            });
        }

        private void sAviatorBack_Click(object sender, EventArgs e)
        {
            SquareForm squareForm = new SquareForm(_username);
            this.Hide();
            squareForm.ShowDialog();
            this.Close();
        }
    }
}
