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
    public partial class DifficultyForm : Form
    {
        public DifficultyForm()
        {
            InitializeComponent();
        }

        private void easyBTN_Click(object sender, EventArgs e)
        {
            var easyGame = new EasyGame();
            easyGame.Show();
        }

        private void NormalBTN_Click(object sender, EventArgs e)
        {
            var normalGame = new NormalGame();
            normalGame.Show();
        }

        private void HardBTN_Click(object sender, EventArgs e)
        {
            var hardGame = new HardGame();
            hardGame.Show();
        }
    }
}
