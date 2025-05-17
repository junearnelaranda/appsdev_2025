using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EyeWear
{
    public partial class RectangleFrames : Form
    {
        private string _username;
        public RectangleFrames(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void RectangleFrames_Load(object sender, EventArgs e)
        {

        }

        private void RectangleBack_Click(object sender, EventArgs e)
        {
            OvalForm ovalForm = new OvalForm(_username);
            this.Hide();
            ovalForm.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://idealvision.ph/product/bolle-f-megeve-eyeglasses-women",
                UseShellExecute = true
            });
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/basic-ba26/",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/classico-cc29/",
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.ojoeyewear.co/collections/classico-cc27/",
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
    }
}
