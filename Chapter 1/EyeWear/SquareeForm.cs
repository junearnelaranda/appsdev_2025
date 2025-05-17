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
    public partial class SquareeForm : Form
    {
        private string _username;
        public SquareeForm(string userName)
        {
            InitializeComponent();
            _username = userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/eleanor",
                UseShellExecute = true
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/jensen",
                UseShellExecute = true
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/roosevelt",
                UseShellExecute = true
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/roosevelt",
                UseShellExecute = true
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/collections/frames-for-round-faces/products/shiro",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/products/columbus",
                UseShellExecute = true
            });
        }

        private void SquareBack_Click(object sender, EventArgs e)
        {
            RoundForm roundForm = new RoundForm(_username);
            this.Hide();
            roundForm.ShowDialog();
            this.Close();
        }

        private void SquareeBack_Click(object sender, EventArgs e)
        {
            RoundForm roundForm = new RoundForm(_username);
            this.Hide();
            roundForm.ShowDialog();
            this.Close();
        }

        private void SquareeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
