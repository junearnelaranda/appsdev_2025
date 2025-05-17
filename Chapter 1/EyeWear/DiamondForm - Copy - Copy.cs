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
    public partial class DiamondForm : Form
    {
        private string _username;
        public DiamondForm(string userName)
        {
            InitializeComponent();
            _username = userName;
        }

        private void DiamondForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DcateyeGlasses dCateyeGlasses = new DcateyeGlasses(_username);
            this.Hide();
            dCateyeGlasses.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dAviatorGlasses DaviatorGlasses = new dAviatorGlasses(_username);
            this.Hide();
            DaviatorGlasses.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dOvalGlasses DovalGlasses = new dOvalGlasses(_username);
            this.Hide();
            DovalGlasses.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dRoundGlasses DroundGlasses = new dRoundGlasses(_username);
            this.Hide();
            DroundGlasses.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dRectangularGlasses DrectangularGlasses = new dRectangularGlasses(_username);
            this.Hide();
            DrectangularGlasses.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dBrowlineGlasses DbrowlineGlasses = new dBrowlineGlasses(_username);
            this.Hide();
            DbrowlineGlasses.ShowDialog();
            this.Close();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dFormBack_Click(object sender, EventArgs e)
        {
            Faces diamondForm = new Faces(_username);
            this.Hide();
            diamondForm.ShowDialog();
            this.Close();
        }

        private void dCateye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This selection of cat-eye frames showcases a variety of interpretations of this classic style. AIR Rim Ar01 offers a modern take with a thin, light-colored frame and subtle upswept temples. Belle Be01 presents a classic tortoiseshell pattern with a more pronounced and elegant cat-eye shape. Comfort Com07 features a bold red frame with a clearly defined and stylish upsweep. Hanamoto H05 also displays a tortoiseshell pattern but with a slightly more rounded lens shape and a less dramatic cat-eye. Polaxplus Pp04 and MOSO M36 appear to be cat-eye sunglasses with darker lenses and thicker frames, offering a more glamorous and shaded look.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dAvaitor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This selection of aviator frames presents a variety of styles. LEVIS LS99027 offers a classic aviator sunglass look with light lenses and a silver-toned frame. Benny features a more squared-off aviator shape with blue lenses and a dark upper bar detail. Chiyo presents an optical aviator style with a light-colored, almost translucent frame. GUCCI GG0351S offers a unique take with gradient lenses (appearing red/pink and green) and a gold-toned double-bridge frame with distinctive green accents on the outer rims. Julius showcases a more traditional gold-toned metal aviator frame for optical use. Lastly, Stella McCartney SC0125O offers a modern and elegant interpretation with a thin, two-toned frame in black and rose gold.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dOval_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This selection of oval frames offers a range of subtle variations on the classic oval shape. Chopard Men's Gold presents a refined look with a thin gold metal frame and gently rounded oval lenses. Bonnie features a slightly wider, soft brown oval frame with a simple and elegant design. Lee offers a similar warm brown tone but with a slightly more defined oval lens shape. Penny showcases a light brown metal frame with a classic, balanced oval silhouette. Kitty stands out with a light-colored, almost cat-eye inspired oval frame, featuring a slight upward flick at the temples and burgundy inner rims. Lastly, Enid offers a thin, light brown metal frame with a distinctly rounded oval lens shape. These frames provide a versatile and often flattering style with their smooth, rounded lines.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dRound_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This selection of round frames presents a variety of stylish options. Agnes B. AB47006 features a classic round shape with a thin black upper rim and a lighter lower rim. FURLA VFU297K showcases a vibrant red, slightly oversized round frame. GUCCI GG0348O offers a bold, thick black round frame for a more pronounced look. Agnes B. AB60033 presents a unique round frame with a teal and brown color combination. Furla VFU355 07T1 offers a translucent, light-colored round frame. Lastly, FURLA VFU358 features a delicate, light gold-toned metal round frame. These frames demonstrate the versatility of the round silhouette in different materials, thicknesses, and colors.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dRectangular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This selection of rectangular frames offers a variety of styles within the classic rectangular shape. 1  Agnes B. ABH45011 features a dark, possibly tortoiseshell patterned frame with a clean, slightly rounded rectangular lens shape. BOLLE F MEGEVE presents a minimalist look with a thin, light-colored metal rectangular frame. BOLLE F MONTPARNASSE offers a similar thin metal frame in a brown tone with a slightly more pronounced rectangular lens shape. CACHAREL CA0012 001 showcases a bold, black rectangular frame with subtly rounded edges. CACHAREL CA0013 offers a similar thick black frame but with a more distinctly sharp rectangular lens shape. Lastly, CACHAREL CA0015 features a black frame with a hint of color on the inner temples and a classic rectangular lens shape. These frames demonstrate the versatility of the rectangular silhouette in different materials, thicknesses, and subtle design variations.   ", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dBrowline_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This selection of browline frames showcases a few variations on the style. Ollie features a bold black upper frame paired with a thin lower rim. Arthur presents a lighter aesthetic with a thin brown metal upper frame. Clyde offers a similar light metal browline in a silver tone. Barragan also features a prominent black upper frame. Madison combines a black upper frame with a contrasting gold lower rim and bridge. Lastly, Wes offers a classic black browline with a subtle curve to the upper frame. These frames highlight the key characteristic of browline glasses: a thicker, more defined upper portion that resembles the line of the eyebrows.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

