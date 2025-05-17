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
    public partial class TriangleForm : Form
    {
        private string _username;
        public TriangleForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CateyeGlasses cateyeGlasses = new CateyeGlasses(_username);
            this.Hide();
            cateyeGlasses.ShowDialog();
            this.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            PilotGlasses pilotGlasses = new PilotGlasses(_username);
            this.Hide();
            pilotGlasses.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RoundovalGlasses roundOvalGlasses = new RoundovalGlasses(_username);
            this.Hide();
            roundOvalGlasses.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tsquareGlasses TsquareGlasses = new tsquareGlasses(_username);
            this.Hide();
            TsquareGlasses.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BrowlineGlasses browlineGlasses = new BrowlineGlasses(_username);
            this.Hide();
            browlineGlasses.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            trimlessGlasses TrimlessGlasses = new trimlessGlasses(_username);
            this.Hide();
            TrimlessGlasses.ShowDialog();
            this.Close();
        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Faces triangleForm = new Faces(_username);
            this.Hide();
            triangleForm.ShowDialog();
            this.Close();

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tCateye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The selection of cat-eye glasses presents distinct styles. AIR Rim Ar01 offers a modern take with a thin, light-colored frame and subtle upswept temples. Belle Be01 showcases a classic tortoiseshell pattern with a more pronounced and elegant cat-eye shape. Comfort Com07 features a bold red frame with a clearly defined and stylish upsweep. Lastly, Hanamoto H05 also displays a tortoiseshell pattern but with a slightly more rounded lens shape and a less dramatic cat-eye. Polaxplus Pp04 and MOSO M36 appear to be cat-eye sunglasses with darker lenses and thicker frames, offering a more glamorous and shaded look.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tPilot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This selection of pilot glasses and sunglasses offers diverse aesthetics. LEVIS LS99027 presents a classic pilot sunglass silhouette with light-colored lenses and a silver-toned frame. Escada SES488K offers a more glamorous, oversized take on the pilot style with dark, gradient lenses and a thick black frame accented with gold details. GUCCI GG0062S features a sporty look with blue lenses and a black and gold double-bridge frame. GUCCI GG0351S provides a colorful option with gradient pink lenses and a unique green and gold frame. GUCCI GG0577OA showcases a more traditional optical pilot frame with thin gold rims and a double bridge. Finally, Stella McCartney SC0125O offers a modern and elegant interpretation with a thin, two-toned frame in black and rose gold.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tRoundglasses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These round frames provide a gentle and timeless style. Ideal for a casual, retro look or for those who seek a warm and intellectual vibe.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tSqaureglasses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These square frames feature a clean and contemporary design. Perfect for a polished, fashionable look or for those who desire a sophisticated and smart appearance.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tBrowline_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This collection features a variety of browline glasses, each with a distinct character. Carson presents a warm, brown upper frame with a subtle design. Antepara AUSTIN AP3028 and Antepara HOUSTON AP302 showcase vibrant blue upper frames, offering a bolder look. CEO-V CV384 combines a classic black upper with a contrasting gold lower rim. CEO-V CV696 offers a more minimalist approach with a sleek black upper frame. Lastly, POLICE DYNAMO1 VPL900 features a stylish tortoiseshell upper frame, adding a touch of classic sophistication to the browline style.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tRimless_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These rimless frames offer a sleek and modern style. Perfect for a minimalist, sophisticated look or for those who prefer a lightweight and unobtrusive design", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}



