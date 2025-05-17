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
    public partial class RoundForm : Form
    {
        private string _username;
        public RoundForm(string userName)
        {
            InitializeComponent();
            _username = userName;
        }

        private void RoundForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrowlineForm BrowlineForm = new BrowlineForm(_username);
            this.Hide();
            BrowlineForm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OversizedForm OversizedForm = new OversizedForm(_username);
            this.Hide();
            OversizedForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PilotForm PilotForm = new PilotForm(_username);
            this.Hide();
            PilotForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RectangleForm RectangleForm = new RectangleForm(_username);
            this.Hide();
            RectangleForm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RounddForm rounddForm = new RounddForm(_username);
            this.Hide();
            rounddForm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SquareeForm SquareeForm = new SquareeForm(_username);
            this.Hide();
            SquareeForm.ShowDialog();
            this.Close();
        }

        private void homeRoundClick_Click(object sender, EventArgs e)
        {
            Home home = new Home(_username);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void shapeRoundClick_Click(object sender, EventArgs e)
        {
            Faces facesForm = new Faces(_username);
            this.Hide();
            facesForm.ShowDialog();
            this.Close();
        }

        private void contactsRoundClick_Click(object sender, EventArgs e)
        {
            Contacts contactsForm = new Contacts(_username);
            this.Hide();
            contactsForm.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rBrow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These browline glasses offer a range of stylish options. Wes features a classic black upper frame paired with a thin lower rim. Madison presents a similar browline style but with a dark brown upper frame. Clyde offers a lighter aesthetic with a silver-toned upper frame. Bastian stands out as a browline sunglass with a solid black upper portion. Gregor combines a light brown upper frame with a thin lower rim. Lastly, Ollie showcases a bold, thick black browline that extends around the entire lens.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rform5Back_Click(object sender, EventArgs e)
        {
            Faces OvalForm = new Faces(_username);
            this.Hide();
            OvalForm.ShowDialog();
            this.Close();
        }

        private void rOvers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This stylish collection features six unique oversized eyeglasses: Franz, Bruno, Dex, Dex+, Gregor, and Ollie. Designed for a bold and modern look, each frame offers a distinct personality—from the retro charm of Franz to the contemporary edge of Dex+. These glasses not only make a statement but also provide comfortable coverage and clear vision for everyday wear.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rPilot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The selection showcases several variations of pilot-style glasses. Franz presents a timeless look with its gold-toned metal frame and double bridge. Magnus offers a similar silhouette in a brown-toned metal. Cliff provides a darker option with its prominent double bridge on a dark metal frame. Bruno softens the style with a light rose gold metal. Tobias offers a modern twist with its unique translucent off-white frame, while Chiyo presents a light brown alternative, all maintaining the characteristic double-bridge design of pilot eyewear.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rRectangle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These rectangular frames offer a sleek and classic style. Perfect for a sophisticated, vintage look or for those who want a confident and smart vibe.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rRound_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These round frames offer a soft and classic style. Perfect for a relaxed, vintage look or for those who want a friendly and smart vibe.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rSquare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These square frames offer a bold and classic style. Perfect for a vintage, sophisticated look or for those who want a confident and smart vibe.", "Description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
