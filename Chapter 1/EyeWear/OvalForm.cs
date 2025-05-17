using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace EyeWear
{
    public partial class OvalForm : Form
    {
        private string _username;
        public OvalForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RectangleFrames RectangleFrames = new RectangleFrames(_username);
            this.Hide();
            RectangleFrames.ShowDialog();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ovalcateye ovalcateye = new ovalcateye(_username);
            this.Hide();
            ovalcateye.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ovalgeometric ovalgeometric = new ovalgeometric(_username);
            this.Hide();
            ovalgeometric.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ovalbrowline ovalbrowline = new ovalbrowline(_username);
            this.Hide();
            ovalbrowline.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ovalaviator ovalaviator = new ovalaviator(_username);
            this.Hide();
            ovalaviator.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ovalrectangle ovalrectangle = new ovalrectangle(_username);
            this.Hide();
            ovalrectangle.ShowDialog();
            this.Close();
        }

        private void OvalForm_Load(object sender, EventArgs e)
        {

        }

        private void RectangleBack_Click(object sender, EventArgs e)
        {
            Faces OvalForm = new Faces(_username);
            this.Hide();
            OvalForm.ShowDialog();
            this.Close();
        }

        private void oBrowline_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These browline frames offer a stylish and classic look. Perfect for a sophisticated, vintage vibe or for those who want a smart and confident appearance.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void oGeometric_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These geometric frames offer a modern and stylish look. Perfect for a bold, contemporary vibe or for those who want a unique and smart appearance.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void oCateye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These cat-eye frames offer a chic and timeless style. Perfect for a sophisticated, vintage look or for those who want a playful and smart vibe.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void oRectangle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These rectangular frames offer a refined and classic style. Perfect for a polished, vintage look or for those who want a sophisticated and smart vibe.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void oRectanglev2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The image showcases a selection of eyeglasses, and among them are a couple of notable rectangular frame styles. One example is the AIR Rim Ar12, which presents a sleek and traditional look with its thin, black rectangular frame. Another rectangular option is the All Day Ad01, distinguished by its thicker frame featuring a stylish tortoiseshell pattern. These two examples illustrate different interpretations of the rectangular frame, offering variations in material thickness and color choice.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void oAvaitor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These aviator frames offer a bold and classic style. Perfect for a relaxed, vintage look or for those who want a confident and smart vibe.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
