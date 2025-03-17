namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] food = { "Filipino", "Japanese", "Chinese", "Korean" };
            comboBox.Items.AddRange(food);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox.Items)
            {
                bool isSelected = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(item));
                if (isSelected && !listBox.Items.Contains(item))
                {
                    listBox.Items.Add(item);
                }
            }
        }

        private void rmvBtn_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1) ;
            {
                listBox.Items.Remove(listBox.SelectedItem);

            }

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void sBtn_Click(object sender, EventArgs e)
        {

            string[] Filipino = { "Ginamos", "Amahong", "Kinilaw", "Hipon", "Bibingka", "Pagpag", "Sioming", "Kinapusan", "Sa-ang", "Halo - Halo", "Maja Blanca"};
            string[] Japanese = { "Ramen", "Onigiri", "Takoyaki", "Udon", "Taiyaki", "Dorayaki", "Dango", "Manju", "Daifuku", "Coffee Jelly" };
            string[] Chinese = { "Mapo tofu", "Wonton soup", "Congee", "Dumplings", "Egg tarts", "Almond cookies", "Mooncakes", "Red Bean Soup " };
            string[] Korean = { "Tteokbokki ", "Kimchi-jjigae", "Bibimbap", "Hotteok", "Dasik", "Sikhye", "Dalgona", "Bingsu" };

            checkedListBox.Items.Clear();

            if (comboBox.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox.Items.AddRange(Filipino);

            }
            else if (comboBox.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox.Items.AddRange(Japanese);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBox.Items.AddRange(Chinese);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Korean"))
            {
                checkedListBox.Items.AddRange(Korean);
            }
        }
    }
}

