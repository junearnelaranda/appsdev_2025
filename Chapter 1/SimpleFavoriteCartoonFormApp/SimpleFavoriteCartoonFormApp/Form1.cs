namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Peter Griffin");
            comboBox1.Items.Add("Lois  Griffin");
            comboBox1.Items.Add("Meg Griffin");
            comboBox1.Items.Add("Chris Griffin");
            comboBox1.Items.Add("Stewie Griffin");
            comboBox1.Items.Add("Brian Griffin");
            comboBox1.Items.Add("Glenn Quagmire");
            comboBox1.Items.Add("Joe Swanson");
            comboBox1.Items.Add("Cleveland Brown");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vwBtn_Click(object sender, EventArgs e)
        {
            string basePath = @"C:\Users\lenovo\OneDrive\Desktop\Chapter 1\SimpleFavoriteCartoonFormApp\Chars\";

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Peter Griffin":
                    pictureBox1.Image = Image.FromFile(basePath + "peter.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Lois  Griffin":
                    pictureBox1.Image = Image.FromFile(basePath + "lois.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Meg Griffin":
                    pictureBox1.Image = Image.FromFile(basePath + "meg.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Chris Griffin":
                    pictureBox1.Image = Image.FromFile(basePath + "chris.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Stewie Griffin":
                    pictureBox1.Image = Image.FromFile(basePath + "stewie.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Brian Griffin":
                    pictureBox1.Image = Image.FromFile(basePath + "brian.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Glenn Quagmire":
                    pictureBox1.Image = Image.FromFile(basePath + "glenn.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Joe Swanson":
                    pictureBox1.Image = Image.FromFile(basePath + "joe.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Cleveland Brown":
                    pictureBox1.Image = Image.FromFile(basePath + "brown.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}

