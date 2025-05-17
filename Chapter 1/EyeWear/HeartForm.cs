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
    public partial class HeartForm : Form
    {
        private string _username;
        public HeartForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RimlessGlasses RimlessGlasses = new RimlessGlasses(_username);
            this.Hide();
            RimlessGlasses.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Hroundf Hroundf = new Hroundf(_username);
            this.Hide();
            Hroundf.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hcateyef Hcateyef = new Hcateyef(_username);
            this.Hide();
            Hcateyef.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Havaitorf Havaitorf = new Havaitorf(_username);
            this.Hide();
            Havaitorf.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hovalf Hovalf = new Hovalf(_username);
            this.Hide();
            Hovalf.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FoxFrame FoxFrame = new FoxFrame(_username);
            this.Hide();
            FoxFrame.ShowDialog();
            this.Close();
        }

        private void HeartForm_Load(object sender, EventArgs e)
        {

        }

        private void HeartBack_Click(object sender, EventArgs e)
        {
            Faces HeartForm = new Faces(_username);
            this.Hide();
            HeartForm.ShowDialog();
            this.Close();
        }

        private void Hfoxframe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This collection presents frames with a stylish upswept design at the temples, often referred to as \"fox frames\" for their resemblance to the shape of a fox's eye. MM1014B-3S C1 offers a subtle lift in a delicate, light-colored metal. AU8005N-1A C1 embodies a more classic \"fox eye\" with its pronounced tortoiseshell upsweep. AU2065N-9A C1 makes a bolder statement with a sharply angled black frame. LB1006G-8A C1 provides a softer interpretation in brown metal with a gentle temple lift. NC3015J-0S C2 offers a lighter feel with a translucent frame and a moderate upsweep. Finally, ECO2018K-0A C1 combines a dark patterned frame with a distinct and fashionable temple flare. These frames capture the essence of the \"fox eye\" trend with varying degrees of emphasis on the upward sweep.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Hround_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This collection of round frame glasses offers a diverse range of styles within the circular aesthetic. AIR Ultem presents a timeless look with its thin black rims. OWNDAYS PC provides a minimalist feel with a slender metal frame. +NICHE stands out with a uniquely designed bridge and temples. ALVARO offers a slightly bolder statement with its thicker brown frames. HIRO exudes a delicate charm with its light gold-toned metal. Lastly, ONO+ presents a modern touch with its light-colored and slightly oversized round silhouette. Each frame offers a distinct take on the classic round shape, catering to various preferences.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Hrimless_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This collection of rimless glasses offers a minimalist and lightweight aesthetic. 1  Each pair features lenses held together primarily by the nose bridge and temple attachments, creating a nearly invisible look. Variations include different lens shapes, ranging from slightly rectangular to more rounded, and subtle differences in the design and color of the bridges and temples, offering a range of understated styles.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Hcateye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("what about this cat eyes frames\r\n\r\n\r\nThis selection of cat-eye frames showcases a variety of interpretations of this classic style. PHOEBE offers a subtle and modern take with a thin, light-colored frame and gentle upsweep. KITTY presents a bolder, more traditional cat-eye shape with a translucent frame accented by red inner rims. GRETA features a softer, rounded cat-eye in a warm brown tone. SYLVIE offers a more dramatic and angular upsweep in a rich brown hue. LANE provides a unique twist with a translucent pink frame and a distinctive, almost rectangular shape with an upward flick at the temples. Lastly, ROWAN offers a more understated and wearable cat-eye in a light brown metal frame with a subtle upsweep.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Havaitor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This collection showcases various styles of aviator sunglasses. NC3025X-3A C1 presents a classic aviator look with brown lenses and a gold-toned double-bridge frame. SUN7006G-4S C2 offers a sleek, modern take with dark lenses and a dark metal frame. SUN1075G-4S C1 features gradient brown lenses and a light-colored metal frame with a double bridge. SUN8013B-3A C4 provides a more contemporary feel with blue-tinted lenses and a blue frame. Havaitor NC2009B-0S C4 sticks to the traditional aviator shape with dark lenses and a dark metal double-bridge frame. Lastly, SUN1037T-9S C1 offers a unique, lighter aesthetic with clear lenses and a minimalist black and silver double-bridge frame, suggesting it might be an optical aviator style.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Hoval_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This selection features oval frame glasses, offering a softer alternative to round or rectangular shapes. Readers Oval 1 presents a classic brown oval frame with a slightly thicker rim. Readers Oval 2 offers a more delicate look with a thin, light silver oval frame. AIR Ultem showcases a slightly elongated oval shape in a tortoiseshell pattern. OR1050T-1A C1 features a half-rim design with rounded oval lenses and a thin brown metal frame. OR1058M-4A C1 displays a full, thin brown metal frame with subtly elongated oval lenses. Lastly, OR1059M-4A C1 offers a similar style with a slightly more pronounced oval lens shape and a thin brown metal frame. These frames provide a gentle and versatile aesthetic.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
