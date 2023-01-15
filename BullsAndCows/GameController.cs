using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    public class GameController
    {
        public static void StartGame()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormGameSettings newSettings = new FormGameSettings();

            newSettings.ShowDialog();
            FromGameBoard CurrentBoard = new FromGameBoard(newSettings.GetRounds);

            while (CurrentBoard.UserWantToRestart.DoesTheUserWantToRestartGame && newSettings.IsGameStarted)
            {
                if (newSettings.IsGameStarted)
                {
                        CurrentBoard.ShowDialog();
                }

                if (CurrentBoard.UserWantToRestart.DoesTheUserWantToRestartGame)
                {
                        newSettings = new FormGameSettings();
                        newSettings.ShowDialog();
                        CurrentBoard = new FromGameBoard(newSettings.GetRounds);
                }
            }
        }
    }
}
