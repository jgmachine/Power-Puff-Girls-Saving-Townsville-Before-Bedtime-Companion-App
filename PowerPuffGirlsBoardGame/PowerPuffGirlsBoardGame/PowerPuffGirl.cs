using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PowerPuffGirlsBoardGame
{
    public class PowerPuffGirl
    {
        private int currentIndex, time, timerLoops;
        public bool isProcessingResult = false;
        private List<int> dice = new List<int>(new int[] { 1, 2, 2, 3, 4, 4 });
        private Label resultBox, dicePoolLabel = new Label();
        private Button lostFightButton = new Button();


        public PowerPuffGirl(Form form, int x, int y, Label aResultBox, Button aLostFightButton, Label aDicePoolLabel)
        {
            time = 0;
            timerLoops = 0;
            currentIndex = -1;

            this.resultBox = aResultBox;
            this.resultBox.Visible = true;
            form.Controls.Add(this.resultBox);
            resultBox.Click += new System.EventHandler(resultBox_Click);

            this.lostFightButton = aLostFightButton;
            this.lostFightButton.Visible = true;
            form.Controls.Add(this.lostFightButton);
            lostFightButton.Click += new System.EventHandler(lostFightButton_Click);

            this.dicePoolLabel = aDicePoolLabel;
            this.dicePoolLabel.Visible = true;
            form.Controls.Add(this.dicePoolLabel);
        }

        private void resultBox_Click(object sender, EventArgs e)
        {
            isProcessingResult = true;
            Label lbl = (Label)sender;
            this.resultBox.Text = returnDiceResult();
        }

        private void lostFightButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (currentIndex != -1)
            {
            dice[currentIndex] = 0;
            this.resultBox.Text = "0";
            dicePoolLabel.Text = "";
            foreach (var result in dice)
                {
                    dicePoolLabel.Text += result;
                }
            }
        }

        private string returnDiceResult()
        {
            currentIndex = Form1.r.Next(0, dice.Count);
            return dice[currentIndex].ToString();
        }

        public void LoadingResultAnimation()
        {

            if (this.isProcessingResult)
            {
                List<string> loadingAnimation = new List<string>(new string[] { "|", "/", "-", "\\" });
                this.resultBox.Text = loadingAnimation[time].ToString();
                time++;
                if (time == 4)
                {
                    time = 0;
                    timerLoops++;
                    if (timerLoops == 2)
                    {
                        timerLoops = 0;
                        this.resultBox.Text = returnDiceResult();
                        this.isProcessingResult = false;
                    }
                }
            }
        }

        public void resetPowerPuffGirl()
        {
            this.dice = new List<int>(new int[] { 1, 2, 2, 3, 4, 4 });
            this.resultBox.Text = "0";
            this.dicePoolLabel.Text = "122344";
            this.currentIndex = -1;
        }
    }
}