using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EyeWear
{
    public partial class OvalGlasses_sqr_ : Form
    {
        private string _username;

        public OvalGlasses_sqr_(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://ph.sunniesstudios.com/products/readers-oval-1?variant=40784802283574",
                UseShellExecute = true
            });

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
                FileName = "https://www.owndays.com/ph/en/products/OR1050T-1A?sku=5974",
                UseShellExecute = true
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.owndays.com/ph/en/products/OR1058M-4A?sku=8228",
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

        private void ovlglBack_Click_1(object sender, EventArgs e)
        {
            SquareForm squareForm = new SquareForm(_username);
            this.Hide();
            squareForm.ShowDialog();
            this.Close();
        }
    }
}
