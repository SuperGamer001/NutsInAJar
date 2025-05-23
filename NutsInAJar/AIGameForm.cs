using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutsInAJar
{
    public partial class AIGameForm : Form
    {
        public AIGameForm()
        {
            InitializeComponent();
        }

        Game g = new Game();

        private void AIGameForm_Load(object sender, EventArgs e)
        {
            AIGuess();
        }

        private void YesBTN_Click(object sender, EventArgs e)
        {
            int attempts = g.GetAttempts();
            if (attempts == 1)
            {
                MessageBox.Show("Wow! I got that on my first try! I guess I'm just lucky! :)");
            }
            else
            {
                MessageBox.Show("Horray! I guessed the right number of nuts in " + attempts + " tries.");
            }
            Close();
        }

        private void NoBTN_Click(object sender, EventArgs e)
        {
            AIGuess();
        }

        private void AIGuess()
        {
            AIGuessTXT.Text = "Thinking...";
            int myGuess = g.GetAIGuess();

            if (myGuess == -1)
            {
                AIGuessTXT.Text = "HEY! YOU CHEATED!";
                MessageBox.Show("You cheated! You can't do that! I will not tolerate with cheaters! Consider game terminated! >:I");
                Close();
            }
            else
            {
                AIGuessTXT.Text = "Are there " + myGuess.ToString() + " nut in a jar?";
            }
        }
    }
}
