using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using PowerPuffGirlsBoardGame.Properties;

namespace PowerPuffGirlsBoardGame
{
    public partial class Form1 : Form
    {
        public List<PowerPuffGirl> powerPuffGirls;

        public static Random r = new Random();

        public int time = 0;
        public int timerLoops = 0;

        public bool runAnimation = false;

        System.Media.SoundPlayer music = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();

            powerPuffGirls = new List<PowerPuffGirl>();

            PowerPuffGirl bubbles = new PowerPuffGirl(this, 25, 25, bubblesResultBox, bubblesLostFightButton, bubblesDicePoolDisplay);
            PowerPuffGirl blossom = new PowerPuffGirl(this, 100, 100, blossomResultBox, blossomLostFightButton, blossomDicePoolDisplay);
            PowerPuffGirl buttercup = new PowerPuffGirl(this, 200, 200, buttercupResultBox, buttercupLostFightButton, buttercupDicePoolDisplay);

            powerPuffGirls.Add(bubbles);
            powerPuffGirls.Add(blossom);
            powerPuffGirls.Add(buttercup);

            timer1.Start();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            foreach(var ppg in powerPuffGirls)
            {
                ppg.LoadingResultAnimation();
            }
        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var ppg in powerPuffGirls)
            {
                ppg.resetPowerPuffGirl();
            }
        }

        private void playMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            music = new System.Media.SoundPlayer(Resources.themesong);
            if (loopToolStripMenuItem.Checked == false)
            {
                music.Play();
            }
            else
            {
                music.PlayLooping();
            }
        }

        private void stopMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            music.Stop();
        }

        private void playLongVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            music = new System.Media.SoundPlayer(Resources.themesong_full);
            if (loopToolStripMenuItem.Checked == false)
            {
                music.Play();
            }
            else
            {
                music.PlayLooping();
            }
            
        }

        private void loopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loopToolStripMenuItem.Checked == false)
            {
                loopToolStripMenuItem.Checked = true;
            }
            else
            {
                loopToolStripMenuItem.Checked = false;
            }
            
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
