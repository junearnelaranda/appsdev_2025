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
    public partial class SquareForm : Form
    {
        private string _username;
        public SquareForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RoundGlasses RoundGlasses = new RoundGlasses(_username);
            this.Hide();
            RoundGlasses.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SquareGlasses SquareGlasses = new SquareGlasses(_username);
            this.Hide();
            SquareGlasses.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GeometricGlasses GeometricGlasses = new GeometricGlasses(_username);
            this.Hide();
            GeometricGlasses.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AviatorGlasses AviatorGlasses = new AviatorGlasses(_username);
            this.Hide();
            AviatorGlasses.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BarrelGlasses BarrelGlasses = new BarrelGlasses(_username);
            this.Hide();
            BarrelGlasses.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OvalGlasses_sqr_ OvalGlasses_Sqr_ = new OvalGlasses_sqr_(_username);
            this.Hide();
            OvalGlasses_Sqr_.ShowDialog();
            this.Close();
        }

        private void SquareForm_Load(object sender, EventArgs e)
        {

        }

        private void SquareBack_Click(object sender, EventArgs e)
        {
            Faces SquareForm = new Faces(_username);
            this.Hide();
            SquareForm.ShowDialog();
            this.Close();
        }

        private void sCircular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These circular glasses present a range of styles within the round frame category. AU2110A-5S C1 offers a classic, thin black round frame for a timeless look. Hugh is a pair of round sunglasses with a tortoiseshell frame and dark lenses. EO Herme Studio HS24920 features a delicate, light gold-toned round frame, providing a softer aesthetic. Agnes B. ABS06009 showcases a bold, thick black round frame for a more pronounced style. Lillybell embodies the quintessential round frame with very thin black rims, emphasizing the circular lenses. Lastly, ECO2017K-0A C1 provides a similar classic round shape but with slightly thicker black frames.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sSquare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These square frames feature a clean and contemporary design. Perfect for a polished, fashionable look or for those who desire a sophisticated and smart appearance.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sAvaitor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These aviator frames deliver a timeless and iconic style. Perfect for a cool, retro look or for those who seek a stylish and adventurous vibe.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sBarrel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This selection features glasses with lens shapes that could be described as elongated or oval, giving them a \"barrel-like\" appearance. OR1049T-1A C1 and OR1038T-9S C1 present thin metal frames in brown and light purple respectively, both showcasing gently elongated oval lenses. OR1031S-8A C3 offers a similar subtle elongation in a light brown frame. JD2031G-9S C1 provides a black frame with rounded rectangular lenses that have a noticeable horizontal stretch. Lastly, AU8002N-1A C1 features a tortoiseshell pattern with distinctly rounded rectangular lenses that also exhibit a horizontal elongation. These frames offer a softened look compared to sharp rectangles, while still providing more definition than purely circular styles.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sOval_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This selection features glasses with lens shapes that could be described as elongated or oval, giving them a \"barrel-like\" appearance. OR1049T-1A C1 and OR1038T-9S C1 present thin metal frames in brown and light purple respectively, both showcasing gently elongated oval lenses. OR1031S-8A C3 offers a similar subtle elongation in a light brown frame. JD2031G-9S C1 provides a black frame with rounded rectangular lenses that have a noticeable horizontal stretch. Lastly, AU8002N-1A C1 features a tortoiseshell pattern with distinctly rounded rectangular lenses that also exhibit a horizontal elongation. These frames offer a softened look compared to sharp rectangles, while still providing more definition than purely circular styles.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sGeometric_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These geometric frames provide a striking and contemporary style. Ideal for a trendy, avant-garde look or for those who seek a sophisticated and creative vibe.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
