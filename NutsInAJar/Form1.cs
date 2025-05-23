namespace NutsInAJar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IGuessBTN_Click(object sender, EventArgs e)
        {
            var difficulty = new DifficultyForm();
            difficulty.Show(); // Use ShowDialog() if you want it modal
        }
    }
}
