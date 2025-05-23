namespace NutsInAJar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void IGuessBTN_Click(object sender, EventArgs e)
        {
            var difficulty = new DifficultyForm();
            difficulty.Show();
        }

        private void AIGuessBTN_Click(object sender, EventArgs e)
        {
            var AIgame = new AIGameForm();
            AIgame.Show();
        }
    }
}
