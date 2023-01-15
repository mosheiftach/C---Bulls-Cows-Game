using System.Windows.Forms;

namespace BullsAndCows
{
    partial class FormGameSettings
    {
        private Button m_ButtonNumberOfChances;
        private Button m_ButtonStartGame;
        private static int m_Count = 4;
        private bool m_IsGameStarted = false;
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

        public int GetRounds
        {
            get { return m_Count; }
        }

        public bool IsGameStarted
        {
            get { return m_IsGameStarted; }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_ButtonNumberOfChances = new System.Windows.Forms.Button();
            this.m_ButtonStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ButtonNumberOfChances
            // 
            this.m_ButtonNumberOfChances.Location = new System.Drawing.Point(48, 29);
            this.m_ButtonNumberOfChances.Name = "m_ButtonNumberOfChances";
            this.m_ButtonNumberOfChances.Size = new System.Drawing.Size(225, 23);
            this.m_ButtonNumberOfChances.TabIndex = 0;
            this.m_ButtonNumberOfChances.Text = "Number of chances : 4";
            this.m_ButtonNumberOfChances.UseVisualStyleBackColor = true;
            this.m_ButtonNumberOfChances.Click += new System.EventHandler(this.CountClicked);
            // 
            // m_ButtonStartGame
            // 
            this.m_ButtonStartGame.Location = new System.Drawing.Point(198, 77);
            this.m_ButtonStartGame.Name = "m_ButtonStartGame";
            this.m_ButtonStartGame.Size = new System.Drawing.Size(75, 23);
            this.m_ButtonStartGame.TabIndex = 1;
            this.m_ButtonStartGame.Text = "Start";
            this.m_ButtonStartGame.UseVisualStyleBackColor = true;
            this.m_ButtonStartGame.Click += new System.EventHandler(this.GameStarted);
            // 
            // FormGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 119);
            this.Controls.Add(this.m_ButtonStartGame);
            this.Controls.Add(this.m_ButtonNumberOfChances);
            this.Name = "FormGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulls & Cows";
            this.ResumeLayout(false);
        }
        #endregion
    }
}