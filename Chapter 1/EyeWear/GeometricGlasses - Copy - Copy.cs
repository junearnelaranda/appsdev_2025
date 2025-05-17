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
    public partial class GeometricGlasses : Form
    {
        private string _username;
        public GeometricGlasses(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.eo-executiveoptical.com/product/eo-herme-studio-hs24912-eyeglasses/",
                UseShellExecute = true
            });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/SNP1026X-5S?sku=8585",
                UseShellExecute = true
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/SR1008B-4A?sku=8194",
                UseShellExecute = true
            });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/JD1045Z-4A?sku=8177",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/AU8007N-3A?sku=7648",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/ECO2028N-4S?sku=7599",
                UseShellExecute = true
            });
        }

        private void sGeometricBack_Click(object sender, EventArgs e)
        {
            SquareForm squareForm = new SquareForm(_username);
            this.Hide();
            squareForm.ShowDialog();
            this.Close();
        }
    }
}
