using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class Game : Form
    {
        /*
         * Initialising variables
         */

        public int[] chamber;
        int i = 0;
        bool roundComplete = false;
        int awayShots = 0;
        int score = 0;

        public Game()
        {
            InitializeComponent();

            /*
             * spin and fire buttons are disabled by default
             */

            radioPointAway.Checked = true;
            btnSpin.Enabled = false;
            btnShoot.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            /*
             * A new array of length 6 is initialised to represent
             * the gun chamber
             */
            chamber = new int[6];

            //Loading sound from resources
            SoundPlayer audio = new SoundPlayer(Properties.Resources.load);
            audio.Play();

            radioPointAway.Enabled = true;
            radioPointAway.Checked = true;

            //Spin button is enabled
            btnSpin.Enabled = true;
        }

        public void btnSpin_Click(object sender, EventArgs e)
        {
            /*
             * Randomly shuffling the chamber
             */
            Random random = new Random();
            int bulletPos = random.Next(0, 6);
            chamber[bulletPos] = 1;

            //Loading spinning sound
            SoundPlayer audio = new SoundPlayer(Properties.Resources.spinchamber);
            audio.Play();

            //Fire button has been enabled
            btnShoot.Enabled = true;
        }

        public void btnShoot_Click(object sender, EventArgs e)
        {

            if (roundComplete)
            {
                i = 0;
                awayShots = 0;
                roundComplete = false;
            }

            //To check if the bullet is being shot away (not on the target)
            if (radioPointAway.Checked)
            {
                if (chamber[i] == 1)
                {
                    //Playing gunshot sound (from the resource)
                    SoundPlayer audio = new SoundPlayer(Properties.Resources.gunshot);
                    audio.Play();
                    MessageBox.Show("The bullet has been fired! Target survives.", "FIRED");
                    RestartGame();
                    return;
                }
                else
                {
                    //Away option is disabled if the bullet has been shot twice pointing away
                    if (awayShots==1)
                    {
                        //No bullet was fired, dry gunshot sound is played
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.drygunshot);
                        audio.Play();
                        score++;
                        radioPointTarget.Checked = true;
                        radioPointAway.Checked = false;
                        radioPointAway.Enabled = false;
                        RestartGame();
                        MessageBox.Show("Both chances to shoot away has been used. Target will be shot! Your score: " + score, "NOT FIRED");
                    }
                    else
                    {
                        //No bullet was fired, dry gunshot sound is played
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.drygunshot);
                        audio.Play();
                    }
                }

                awayShots++;
            }
            /*
             * Bullet is ready to fired (current position has bullet loaded)
             */
            if (chamber[i] == 1)
            {

                //Playing gunshot sound (from the resource)
                SoundPlayer audio = new SoundPlayer(Properties.Resources.gunshot);
                audio.Play();
                //If the bullet was fired at the target
                if (radioPointTarget.Checked)
                {
                    MessageBox.Show("Congratulations " + ReferClass.playerName +"! The target has been shot.", "FIRED");
                    score = 0;
                }

                //This round has been completed.
                RestartGame();

            }
            else
            {
                //No bullet was fired, dry gunshot sound is played
                SoundPlayer audio = new SoundPlayer(Properties.Resources.drygunshot);
                audio.Play();
            }
            i++;
        }

        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            ReferClass.ExitGame(this);
        }

        private void RestartGame()
        {
            roundComplete = true;
            i = 0;
            awayShots = 0;
            btnShoot.Enabled = false;
            btnSpin.Enabled = false;
        }
    }
}
