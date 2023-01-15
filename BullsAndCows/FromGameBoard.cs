using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    public partial class FromGameBoard : Form
    {
        public FromGameBoard(int i_numberOfRounds)
        {
            int counterForPossitions = 0;

            this.m_CurrentGame.SetUserRoundListsGuessesAndColor(i_numberOfRounds);
            InitializeComponent();
            for (int j = 0; j <= i_numberOfRounds; j++)
            {
                List<Button> tempList = new List<Button>();

                this.m_ButtonsGameBoard.Add(tempList);
                for (int i = 0; i < this.r_NumOfButtonsPerLayer; i++)
                {
                    if (j == 0 && i == r_NumOfUserAndPCGuess)
                    {
                        break;
                    }

                    this.m_ButtonsGameBoard[j].Add(new Button());
                    if (j == 0)
                    {
                        this.m_ButtonsGameBoard[j][i].BackColor = Color.Black;

                    }
                    else
                    {
                        this.m_ButtonsGameBoard[j][i].BackColor = Color.Transparent;

                    }

                    if (i == 0)
                    {
                        this.m_ButtonsGameBoard[j][i].Location = new Point(this.m_ButtomWidthReflaction, this.m_ButtonHightReflaction);
                        this.m_ButtonsGameBoard[j][i].Size = new Size(44, 40);

                        if (j != 0)
                        {
                            this.m_ButtonsGameBoard[j][i].Click += new System.EventHandler(this.ChosenColor);
                            this.m_ButtonsGameBoard[j][i].Name = j.ToString()+i.ToString();
                        }
                    }
                    else if(i < r_NumOfUserAndPCGuess)
                    {
                        this.m_ButtonsGameBoard[j][i].Location = new Point(this.m_ButtonsGameBoard[j][i - 1].Right + m_ButtomWidthReflaction, m_ButtonHightReflaction);
                        this.m_ButtonsGameBoard[j][i].Size = new Size(44, 40);
                        this.m_ButtonsGameBoard[j][i].Name = j.ToString() + i.ToString();

                        if (j != 0)
                        {
                            this.m_ButtonsGameBoard[j][i].Click += new System.EventHandler(this.ChosenColor);
                        }
                    }
                    else if (i == r_NumOfUserAndPCGuess)
                    {
                        this.m_ButtonsGameBoard[j][i].Location = new Point(this.m_ButtonsGameBoard[j][i - 1].Right + m_ButtomWidthReflaction, m_ButtonHightReflaction+9);
                        this.m_ButtonsGameBoard[j][i].Size=new Size(38, 25);
                        this.m_ButtonsGameBoard[j][i].Text = "--->";
                        this.m_ButtonsGameBoard[j][i].Name = j.ToString();
                        this.m_ButtonsGameBoard[j][i].Click += new System.EventHandler(this.ArrowClickedCheckComparrations);
                        this.m_ButtonsGameBoard[j][i].Enabled = false;
                    }
                    else if (i > r_NumOfUserAndPCGuess)
                    {
                        if (counterForPossitions < 2)
                        {
                            this.m_ButtonsGameBoard[j][i].Location = new Point(this.m_ButtonsGameBoard[j][i - 1].Right + m_ButtomWidthReflaction, m_ButtonHightReflaction);
                            this.m_ButtonsGameBoard[j][i].Size = new Size(18, 15);
                        }
                        else
                        {
                            this.m_ButtonsGameBoard[j][i].Location = new Point(this.m_ButtonsGameBoard[j][i - 3].Right + m_ButtomWidthReflaction, m_ButtonHightReflaction+19);
                            this.m_ButtonsGameBoard[j][i].Size = new Size(18, 15);
                        }

                        counterForPossitions++;
                    }
                    
                    this.Controls.Add(this.m_ButtonsGameBoard[j][i]);
                    this.ClientSize = new Size(this.m_ButtonsGameBoard[j][i].Size.Width + this.m_ButtonsGameBoard[j][i].Location.X+10,
                        this.m_ButtonsGameBoard[j][i].Size.Height + this.m_ButtonsGameBoard[j][i].Location.Y+10);
                }

                counterForPossitions = 0;
                if (j == 0)
                {
                    this.m_ButtonHightReflaction += 65;
                }
                else
                {
                    this.m_ButtonHightReflaction += 45;
                }
            }
        }

        private void ChosenColor(object sender, EventArgs e)
        {
            string possitionHolder = (sender as Button).Name;
            FormPickColor currentPickColor = new FormPickColor();

            currentPickColor.StartPosition = FormStartPosition.CenterParent;
            currentPickColor.ShowDialog(this);
            if (currentPickColor.IsColorChose)
            {
                if (this.m_CurrentGame.CheckIfCoulorDoubled(int.Parse(possitionHolder[0].ToString()) - 1,
                    currentPickColor.CurrentButtonThatWasChoose.BackColor))
                {
                    MessageBox.Show("You Placed Duplicate Colors In The Same Row", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    (sender as Button).BackColor = currentPickColor.CurrentButtonThatWasChoose.BackColor;
                    this.m_CurrentGame.AddCurrentColorPossitionInList(int.Parse(possitionHolder[0].ToString()) - 1,
                        int.Parse(possitionHolder[1].ToString()), currentPickColor.CurrentButtonThatWasChoose.BackColor);
                }

                if (!this.m_CurrentGame.CheckIfLineNotFilledAndSetGuessInAndNotInPlace(
                    int.Parse(possitionHolder[0].ToString()) - 1))
                {
                    this.m_ButtonsGameBoard[int.Parse(possitionHolder[0].ToString())][this.r_ArrowPossition].Enabled =
                        true;
                }
            }
        }

        private void ArrowClickedCheckComparrations(object sender, EventArgs e)
        {
            int possitionHolder = int.Parse((sender as Button).Name);

            m_NumberOfLayersThatWasEnabled++;
            if (m_CurrentGame.GetComparrationInPlace(possitionHolder - 1) == r_NumOfUserAndPCGuess)
            {
                this.m_ButtonsGameBoard[0][0].BackColor = this.m_CurrentGame.PcGuessesColors[0];
                this.m_ButtonsGameBoard[0][1].BackColor = this.m_CurrentGame.PcGuessesColors[1];
                this.m_ButtonsGameBoard[0][2].BackColor = this.m_CurrentGame.PcGuessesColors[2];
                this.m_ButtonsGameBoard[0][3].BackColor = this.m_CurrentGame.PcGuessesColors[3];
                MessageBox.Show("YOU WON GOOD JOB!", "Congratulations", MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                for (int i = 0; i < this.m_ButtonsGameBoard.Count; i++)
                {
                    for (int j = 0; j < this.m_ButtonsGameBoard[i].Count; j++)
                    {
                        if (this.m_ButtonsGameBoard[i][j].Enabled == true)
                        {
                            this.m_ButtonsGameBoard[i][j].Enabled = false;
                        }
                    }
                }
            }
            else
            {
                int possitionHolderCurrectGuesses= r_CurrectGuessStartIndex;

                for (int i = 0; i < m_CurrentGame.GetComparrationInPlace(possitionHolder - 1); i++)
                {
                    this.m_ButtonsGameBoard[possitionHolder][possitionHolderCurrectGuesses].BackColor =
                         Color.Black;
                    possitionHolderCurrectGuesses += 1;
                }

                for (int i = 0; i < m_CurrentGame.GetComparrationNotInPlace(possitionHolder - 1); i++)
                {
                    this.m_ButtonsGameBoard[possitionHolder][possitionHolderCurrectGuesses].BackColor =
                        Color.Yellow;
                    possitionHolderCurrectGuesses += 1;
                }
            }

            for (int i = 0; i < this.r_NumOfButtonsPerLayer; i++)
            {
                this.m_ButtonsGameBoard[possitionHolder][i].Enabled = false;
            }

            if (this.m_NumberOfLayersThatWasEnabled == this.m_ButtonsGameBoard.Count-1)
            {
                this.m_ButtonsGameBoard[0][0].BackColor = this.m_CurrentGame.PcGuessesColors[0];
                this.m_ButtonsGameBoard[0][1].BackColor = this.m_CurrentGame.PcGuessesColors[1];
                this.m_ButtonsGameBoard[0][2].BackColor = this.m_CurrentGame.PcGuessesColors[2];
                this.m_ButtonsGameBoard[0][3].BackColor = this.m_CurrentGame.PcGuessesColors[3];
                MessageBox.Show("YOU LOST! Click 'X' To Exit Or Renew The Game", "GetBetterNextTime", MessageBoxButtons.OK,
                    MessageBoxIcon.None);
            }
        }

        private void FromGameBoard_Load(object sender, EventArgs e)
        {
            this.m_IsUserWantToReset.ShowDialog();
        }

        public FormWantsToRestartGame UserWantToRestart
        {
            get { return this.m_IsUserWantToReset; }
        }
    }
}
