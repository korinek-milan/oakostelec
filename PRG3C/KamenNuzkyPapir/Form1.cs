using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        ESelection selected = ESelection.None;
        int victory = 0;
        int loose = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void RockBtn_Click(object sender, EventArgs e)
        {
            selected = ESelection.Rock;
            LetsPlay();
        }

        private void ScissorsBtn_Click(object sender, EventArgs e)
        {
            selected = ESelection.Scissors;
            LetsPlay();
        }
        private void PaperBtn_Click(object sender, EventArgs e)
        {
            selected = ESelection.Paper;
            LetsPlay();
        }

        private void TapirBtn_Click(object sender, EventArgs e)
        {
            selected = ESelection.Tapir;
            LetsPlay();
        }

        private void SpockBtn_Click(object sender, EventArgs e)
        {
            selected = ESelection.Spock;
            LetsPlay();
        }



        private void LetsPlay()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 6);
            ESelection echoice = (ESelection)choice;
            switch (choice)
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

            if (echoice == selected)
            {
                VictoryLabel.Text = "Remíza";
                VictoryLabel.ForeColor = Color.Yellow;
            }
            else if (echoice == ESelection.Rock)
            {
                if (selected == ESelection.Scissors || selected == ESelection.Tapir)
                {
                    Loose();
                }
                else
                {
                    Victory();
                }
            }
            else if (echoice == ESelection.Scissors)
            {
                if (selected == ESelection.Tapir || selected == ESelection.Paper)
                {
                    Loose();
                }
                else
                {
                    Victory();
                }
            }
            else if (echoice == ESelection.Paper)
            {
                if (selected == ESelection.Spock || selected == ESelection.Rock)
                {
                    Loose();
                }
                else
                {
                    Victory();
                }
            }
            else if (echoice == ESelection.Tapir)
            {
                if (selected == ESelection.Spock || selected == ESelection.Paper)
                {
                    Loose();
                }
                else
                {
                    Victory();
                }
            }
            else if (echoice == ESelection.Spock)
            {
                if (selected == ESelection.Rock || selected == ESelection.Scissors)
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

        
    }
}
