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
    public partial class NormalGame : Form
    {
        public NormalGame()
        {
            InitializeComponent();
        }

        Game g = new Game();

        private void enterBTN_Click(object sender, EventArgs e)
        {
            if (g.Guess(MyGuessTXT.Text))
            {
                Close();
            }
        }

        private void NormalGame_Load(object sender, EventArgs e)
        {
            g.Start(10, "normal");
        }
    }
}
