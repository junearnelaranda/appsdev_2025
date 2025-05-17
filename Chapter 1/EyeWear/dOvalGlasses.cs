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
    public partial class dOvalGlasses : Form
    {
        private string _username;
        public dOvalGlasses(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void dOvalGlasses_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DiamondForm ovGlasses = new DiamondForm(_username);
            this.Hide();
            ovGlasses.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://visionexpress.ph/products/chopard-vchd34j-c0l27-eyeglasses-with-free-blue-safe-anti-radiation-lenses?_pos=2&_sid=6f9927ef2&_ss=r&_fid=665727c0a",
                UseShellExecute = true
            });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/optical-1/products/bonnie",
                UseShellExecute = true
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/optical-1/products/lee",
                UseShellExecute = true
            });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/optical-1/products/penny",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/optical-1/products/kitty",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/optical-1/products/enid",
                UseShellExecute = true
            });
        }
    }
}
