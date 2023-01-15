using System.Collections.Generic;
using System.Windows.Forms;

namespace BullsAndCows
{
    partial class FromGameBoard
    {
        private List<List<Button>> m_ButtonsGameBoard = new List<List<Button>>();
        private readonly int r_NumOfButtonsPerLayer = 9;
        private readonly int r_NumOfUserAndPCGuess = 4;
        private int m_ButtonHightReflaction = 7;
        private int m_ButtomWidthReflaction = 7;
        private GameLogic m_CurrentGame = new GameLogic();
        private readonly int r_ArrowPossition = 4;
        private readonly int r_CurrectGuessStartIndex = 5;
        private int m_NumberOfLayersThatWasEnabled = 0;
        private FormWantsToRestartGame m_IsUserWantToReset = new FormWantsToRestartGame();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FromGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 317);
            this.Name = "FromGameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBoard";
            this.Closed += new System.EventHandler(this.FromGameBoard_Load);
            this.ResumeLayout(false);
        }
        #endregion
    }
}

