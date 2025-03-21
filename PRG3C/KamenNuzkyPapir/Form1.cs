using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KamenNuzkyPapir
{
    enum ESelection
    {
        None,
        Rock,
        Scissors,
        Paper,
        Tapir,
        Spock
    }
    public partial class Form1 : Form
    {

        ESelection playerSelection = ESelection.None;
        int victory = 0;
        int loose = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void RockBtn_Click(object sender, EventArgs e)
        {
            playerSelection = ESelection.Rock;
            LetsPlay();
        }

        private void ScissorsBtn_Click(object sender, EventArgs e)
        {
            playerSelection = ESelection.Scissors;
            LetsPlay();
        }
        private void PaperBtn_Click(object sender, EventArgs e)
        {
            playerSelection = ESelection.Paper;
            LetsPlay();
        }

        private void TapirBtn_Click(object sender, EventArgs e)
        {
            playerSelection = ESelection.Tapir;
            LetsPlay();
        }

        private void SpockBtn_Click(object sender, EventArgs e)
        {
            playerSelection = ESelection.Spock;
            LetsPlay();
        }



        private void LetsPlay()
        {
            Random rnd = new Random();
            int enemyChoice = rnd.Next(1, 6);
            ESelection eEnemyChoice = (ESelection)enemyChoice;
            switch (enemyChoice)
            {
                case 1:
                    EnemyChoice.Image = KamenNuzkyPapir.Properties.Resources.stone;
                    break;
                case 2:
                    EnemyChoice.Image = KamenNuzkyPapir.Properties.Resources.scissors;
                    break;
                case 3:
                    EnemyChoice.Image = KamenNuzkyPapir.Properties.Resources.paper;
                    break;
                case 4:
                    EnemyChoice.Image = KamenNuzkyPapir.Properties.Resources.tapir;
                    break;
                case 5:
                    EnemyChoice.Image = KamenNuzkyPapir.Properties.Resources.spock;
                    break;
            }

            if (eEnemyChoice == playerSelection)
            {
                VictoryLabel.Text = "Remíza";
                VictoryLabel.ForeColor = Color.Yellow;
            }
            else if (eEnemyChoice == ESelection.Rock)
            {
                if (playerSelection == ESelection.Scissors || playerSelection == ESelection.Tapir)
                {
                    Loose();
                }
                else
                {
                    Victory();
                }
            }
            else if (eEnemyChoice == ESelection.Scissors)
            {
                if (playerSelection == ESelection.Tapir || playerSelection == ESelection.Paper)
                {
                    Loose();
                }
                else
                {
                    Victory();
                }
            }
            else if (eEnemyChoice == ESelection.Paper)
            {
                if (playerSelection == ESelection.Spock || playerSelection == ESelection.Rock)
                {
                    Loose();
                }
                else
                {
                    Victory();
                }
            }
            else if (eEnemyChoice == ESelection.Tapir)
            {
                if (playerSelection == ESelection.Spock || playerSelection == ESelection.Paper)
                {
                    Loose();
                }
                else
                {
                    Victory();
                }
            }
            else if (eEnemyChoice == ESelection.Spock)
            {
                if (playerSelection == ESelection.Rock || playerSelection == ESelection.Scissors)
                {
                    Loose();
                }
                else
                {
                    Victory();
                }
            }
        }

        private void Loose()
        {
            VictoryLabel.Text = "Prohra";
            VictoryLabel.ForeColor = Color.Red;
            loose += 1;
            WinLooseRatio();
        }
        private void Victory()
        {
            VictoryLabel.Text = "Výhra";
            VictoryLabel.ForeColor = Color.Green;
            victory += 1;
            WinLooseRatio();
        }

        private void WinLooseRatio()
        {
            float wl;
            if (loose == 0)
            {
                wl = 1;
            }
            else
            {
                wl = (float)victory / (float)loose;
            }
            WinLooseRatioLbl.Text = "V/P: " + Math.Round(wl, 2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawLine(stoneBtn, 2, ScissorsBtn, 0, e);
            drawLine(stoneBtn, 2, TapirBtn, 0, e);

            drawLine(ScissorsBtn, 3, TapirBtn, 1, e);
            drawLine(ScissorsBtn, 0, PaperBtn, 2, e);

            drawLine(PaperBtn, 0, stoneBtn, 1, e);
            drawLine(PaperBtn, 3, SpockBtn, 1, e);

            drawLine(TapirBtn, 0, PaperBtn, 3, e);
            drawLine(TapirBtn, 0, SpockBtn, 2, e);

            drawLine(SpockBtn, 0, stoneBtn, 3, e);
            drawLine(SpockBtn, 1, ScissorsBtn, 0, e);
        }

        /**
         * edge 0 = top, 1 = right, 2 = bottom, 3 = left
         * */
        private void drawLine(Control c1, int edge1, Control c2, int edge2,  PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            int shift1X = 0;
            int shift1Y = 0;
            int shift2X = 0;
            int shift2Y = 0;
            calculateShift(c1, edge1, out shift1X, out shift1Y);
            calculateShift(c2, edge2, out shift2X, out shift2Y);

            pen.CustomEndCap = new AdjustableArrowCap(5, 5);

            e.Graphics.DrawLine(pen, c1.Location.X + shift1X, c1.Location.Y + shift1Y, c2.Location.X + shift2X, c2.Location.Y + shift2Y);

            //e.Graphics.DrawLine(pen, c1.Location.X + shift1X, c1.Location.Y + shift1Y, c2.Location.X + shift2X, c2.Location.Y + shift2Y);
        }

        private void calculateShift(Control c1, int edge1, out int shift1X, out int shift1Y)
        {
            shift1X = 0;
            shift1Y = 0;
            switch (edge1)
            {
                case 0:
                    shift1X = c1.Width / 2;
                    shift1Y = 0;
                    break;
                case 1:
                    shift1X = c1.Width;
                    shift1Y = c1.Height / 2;
                    break;
                case 2:
                    shift1X = c1.Width / 2;
                    shift1Y = c1.Height;
                    break;
                case 3:
                    shift1X = 0;
                    shift1Y = c1.Height / 2;
                    break;
            }
        }
    }
}
