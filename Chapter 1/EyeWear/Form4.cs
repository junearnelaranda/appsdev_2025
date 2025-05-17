using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeWear
{
    public partial class Faces : Form
    {
        private string _username;

        public Faces(string userName)
        {
            InitializeComponent();
            _username = userName;


        }

        private void homeClick2_Click(object sender, EventArgs e)
        {
            Home home = new Home(_username);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void shapeClick2_Click(object sender, EventArgs e)
        {
            Faces facesForm = new Faces(_username);
            this.Hide();
            facesForm.ShowDialog();
            this.Close();
        }
        private void contactsClick2_Click(object sender, EventArgs e)
        {
            Contacts contactsForm = new Contacts(_username);
            this.Hide();
            contactsForm.ShowDialog();
            this.Close();
        }

        private void Round_pictureBox_Click(object sender, EventArgs e)
        {
            RoundForm roundForm = new RoundForm(_username);
            this.Hide();
            roundForm.ShowDialog();
            this.Close();
        }

        private void Oval_pictureBox_Click(object sender, EventArgs e)
        {
            OvalForm OvalForm = new OvalForm(_username);
            this.Hide();
            OvalForm.ShowDialog();
            this.Close();
        }

        private void Square_pictureBox_Click(object sender, EventArgs e)
        {
            SquareForm SquareForm = new SquareForm(_username);
            this.Hide();
            SquareForm.ShowDialog();
            this.Close();
        }

        private void Heart_pictureBox_Click(object sender, EventArgs e)
        {
            HeartForm HeartForm = new HeartForm(_username);
            this.Hide();
            HeartForm.ShowDialog();
            this.Close();
        }

        private void Triangle_pictureBox_Click(object sender, EventArgs e)
        {
            TriangleForm triangleForm = new TriangleForm(_username);
            this.Hide();
            triangleForm.ShowDialog();
            this.Show();
        }

        private void Diamond_pictureBox_Click(object sender, EventArgs e)
        {
            DiamondForm diamondForm = new DiamondForm(_username);
            this.Hide();
            diamondForm.ShowDialog();
            this.Close();
        }

        private void Faces_Load(object sender, EventArgs e)
        {

        }

        private void Sprofile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(_username);
            this.Hide();
            profile.ShowDialog();
            this.Close();
        }
    }
}
