using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class RussianRoulette : Form
    {
        //Name of the player
        public RussianRoulette()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //Getting the player name from the text box
            ReferClass.playerName = boxName.Text;

            //Main form is displayed
            Game f = new Game();
            f.ShowDialog();

            ReferClass.ExitGame(this);
        }

        //Exit button
        private void btnExitMain_Click(object sender, EventArgs e)
        {
            ReferClass.ExitGame(this);
        }
    }
}
