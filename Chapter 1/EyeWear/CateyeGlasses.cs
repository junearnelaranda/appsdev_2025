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
    public partial class CateyeGlasses : Form
    {
        private String _username;
        public CateyeGlasses(string userName)
        {
            InitializeComponent();
            _username = userName;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/air-rim-ar01/",
                UseShellExecute = true
            });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/belle-be01/",
                UseShellExecute = true
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/polaxplus-pp04/",
                UseShellExecute = true
            });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/comfort-com07/",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/hanamoto-h05/",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/moso-m36/",
                UseShellExecute = true
            });
        }

        private void CateyeGlasses_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
           TriangleForm cateyeGlasses = new TriangleForm(_username);
            this.Hide();
            cateyeGlasses.ShowDialog();
            this.Close();
        }

        private void balikButton(object sender, EventArgs e)
        {

        }
    }
}
