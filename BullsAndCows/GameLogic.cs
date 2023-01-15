using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    public class GameLogic
    {
        private const int c_NumGuessPerRound = 4;
        private List<List<Color>> m_UserRoundsInputs = new List<List<Color>>();
        private Color[] m_PcGuess = new Color[c_NumGuessPerRound];
        private ColorsToPlay m_ColorToChooseFrom = new ColorsToPlay();
        private List<int> m_CurrectGussesInPlace = new List<int>();
        private List<int> m_CurrectGussesNotInPlace = new List<int>();

        public GameLogic()
        {
            Random tempRandomToGeneratRandomNumber = new Random();
            bool[] preventDoubleColorFlagArray = new bool[m_ColorToChooseFrom.Count];
            int countValidNumOfGuesses = 0;

            while (countValidNumOfGuesses < c_NumGuessPerRound)
            {
                int tempToHoldAsciiValue = tempRandomToGeneratRandomNumber.Next(m_ColorToChooseFrom.Count - 1);

                if (tempToHoldAsciiValue == 0 && preventDoubleColorFlagArray[0] == false)
                {
                    m_PcGuess[countValidNumOfGuesses] = m_ColorToChooseFrom.Aqua;
                    preventDoubleColorFlagArray[0] = true;
                    countValidNumOfGuesses++;
                }
                else if (tempToHoldAsciiValue == 1 && preventDoubleColorFlagArray[1] == false)
                {
                    m_PcGuess[countValidNumOfGuesses] = m_ColorToChooseFrom.Blue;
                    preventDoubleColorFlagArray[1] = true;
                    countValidNumOfGuesses++;
                }
                else if (tempToHoldAsciiValue == 2 && preventDoubleColorFlagArray[2] == false)
                {
                    m_PcGuess[countValidNumOfGuesses] = m_ColorToChooseFrom.DarkSlateGray;
                    preventDoubleColorFlagArray[2] = true;
                    countValidNumOfGuesses++;
                }
                else if (tempToHoldAsciiValue == 3 && preventDoubleColorFlagArray[3] == false)
                {
                    m_PcGuess[countValidNumOfGuesses] = m_ColorToChooseFrom.Purple;
                    preventDoubleColorFlagArray[3] = true;
                    countValidNumOfGuesses++;
                }
                else if (tempToHoldAsciiValue == 4 && preventDoubleColorFlagArray[4] == false)
                {
                    m_PcGuess[countValidNumOfGuesses] = m_ColorToChooseFrom.Green;
                    preventDoubleColorFlagArray[4] = true;
                    countValidNumOfGuesses++;
                }
                else if (tempToHoldAsciiValue == 5 && preventDoubleColorFlagArray[5] == false)
                {
                    m_PcGuess[countValidNumOfGuesses] = m_ColorToChooseFrom.Orange;
                    preventDoubleColorFlagArray[5] = true;
                    countValidNumOfGuesses++;
                }
                else if (tempToHoldAsciiValue == 6 && preventDoubleColorFlagArray[6] == false)
                {
                    m_PcGuess[countValidNumOfGuesses] = m_ColorToChooseFrom.Pink;
                    preventDoubleColorFlagArray[6] = true;
                    countValidNumOfGuesses++;
                }
                else if (tempToHoldAsciiValue == 7 && preventDoubleColorFlagArray[7] == false)
                {
                    m_PcGuess[countValidNumOfGuesses] = m_ColorToChooseFrom.Red;
                    preventDoubleColorFlagArray[7] = true;
                    countValidNumOfGuesses++;
                }
            }
        }

        public void SetUserRoundListsGuessesAndColor(int i_NumOfRounds)
        {
            for (int i = 0; i < i_NumOfRounds; i++)
            {
                List<Color> tempColorToAdd = new List<Color>();

                for (int j = 0; j < c_NumGuessPerRound; j++)
                {
                    tempColorToAdd.Add(Color.Transparent);
                }

                this.m_CurrectGussesInPlace.Add(0);
                this.m_CurrectGussesNotInPlace.Add(0);
                m_UserRoundsInputs.Add(tempColorToAdd);
            }
        }

        public bool CheckIfCoulorDoubled(int i_Layer, Color i_CurrentColor)
        {
            bool resultOfCheck= false;

            for (int i = 0; i < c_NumGuessPerRound; i++)
            {
                if (this.m_UserRoundsInputs[i_Layer][i] == i_CurrentColor)
                {
                    resultOfCheck = true;
                    break;
                }
            }

            return resultOfCheck;
        }

        public void AddCurrentColorPossitionInList(int i_Layer, int i_PossitinInLayer, Color i_ButtonColor)
        {
            this.m_UserRoundsInputs[i_Layer][i_PossitinInLayer] = i_ButtonColor;
        }

        public bool CheckIfLineNotFilledAndSetGuessInAndNotInPlace(int i_Layer)
        {
            bool resultOfCheck = false;

            for (int i = 0; i < c_NumGuessPerRound; i++)
            {
                if (this.m_UserRoundsInputs[i_Layer][i] == Color.Transparent)
                {
                    resultOfCheck = true;
                    break;
                }
            }

            if (!resultOfCheck)
            {
                SetHowManyGuessesInPlace(i_Layer);
                SetHowManyGuessesNotInPlace(i_Layer);
            }

            return resultOfCheck;
        }

        private void SetHowManyGuessesInPlace(int i_Layer)
        {
            int counterForInPlace = 0;

            for (int i = 0; i < c_NumGuessPerRound; i++)
            {
                if (m_UserRoundsInputs[i_Layer][i] == m_PcGuess[i])
                {
                    counterForInPlace++;
                }
            }

            this.m_CurrectGussesInPlace[i_Layer] = counterForInPlace;
        }
        private void SetHowManyGuessesNotInPlace(int i_Layer)
        {
            int counterForNotInPlace = 0;

            for (int i = 0; i < c_NumGuessPerRound; i++)
            {
                for (int j = 0; j < c_NumGuessPerRound; j++)
                {
                    if (this.m_PcGuess[i] ==
                        m_UserRoundsInputs[i_Layer][j] && i != j)
                    {
                        counterForNotInPlace++;
                    }
                }
            }

            this.m_CurrectGussesNotInPlace[i_Layer] = counterForNotInPlace;
        }

        public int GetComparrationInPlace(int i_Layer)
        {
            return this.m_CurrectGussesInPlace[i_Layer];
        }

        public int GetComparrationNotInPlace(int i_Layer)
        {
            return this.m_CurrectGussesNotInPlace[i_Layer];
        }

        public Color[] PcGuessesColors
        {
            get
            {
                return m_PcGuess;
            }
        }
    }
}
