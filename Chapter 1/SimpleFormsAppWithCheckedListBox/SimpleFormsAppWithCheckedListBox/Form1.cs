namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movies = { "The Wizard of Oz", "The Matrix", "The Three Stooges", "The Lord of the Rings", "Ang Probinsyano", "The Godfather", "Shrek", "Despicable Me", "Wallace & Gromit", "Puss in Boots", "Tom and Jerry", "The Pursuit of Happyness", "Slumdog Millionaire" };

            checkedListBox.Items.AddRange(movies);
            checkedListBox.CheckOnClick = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var movies in checkedListBox.Items)
            {
                bool isSelected = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(movies));
                if (isSelected && !listBox.Items.Contains(movies))
                {
                    listBox.Items.Add(movies);
                }
            }
        }
        private void dltBtn_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
