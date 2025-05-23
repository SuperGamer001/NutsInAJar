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
    public partial class EasyGame : Form
    {
        public EasyGame()
        {
            InitializeComponent();
        }

        int numberOfNuts = 0;

        private void enterBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MyGuessTXT.Text))
            {
                MessageBox.Show("Please enter a guess.");
                return;
            }
            if (int.TryParse(MyGuessTXT.Text, out int guess))
            {
                if (guess < 0 || guess > 100)
                {
                    MessageBox.Show("Please enter a number between 0 and 10.");
                    return;
                }
                
                if (guess == numberOfNuts)
                {
                    MessageBox.Show("Congratulations! You guessed the correct number of nuts!");
                    this.Close();
                }
                else if (guess < numberOfNuts)
                {
                    MessageBox.Show("Too low! Try again.");
                }
                else
                {
                    MessageBox.Show("Too high! Try again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void EasyGame_Load(object sender, EventArgs e)
        {
            numberOfNuts = new Random().Next(0, 11); // Random number between 0 and 10
        }
    }
}
