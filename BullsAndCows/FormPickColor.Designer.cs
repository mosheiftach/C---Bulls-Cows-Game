using System.Windows.Forms;


namespace BullsAndCows
{
    partial class FormPickColor
    {
        private Button m_ButtonRed;
        private Button m_ButtonAqua;
        private Button m_ButtonPurple;
        private Button m_ButtonGreen;
        private Button m_ButtonDarkGray;
        private Button m_ButtonPink;
        private Button m_ButtonOrange;
        private Button m_ButtonBlue;
        private Button m_ChoosenColor;
        private bool m_ColorWasChose = false;
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

        public bool IsColorChose
        {
            get
            {
                return m_ColorWasChose;
            }
        }

        public Button CurrentButtonThatWasChoose
        {
            get
            {
                return m_ChoosenColor;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_ButtonRed = new System.Windows.Forms.Button();
            this.m_ButtonAqua = new System.Windows.Forms.Button();
            this.m_ButtonPurple = new System.Windows.Forms.Button();
            this.m_ButtonGreen = new System.Windows.Forms.Button();
            this.m_ButtonDarkGray = new System.Windows.Forms.Button();
            this.m_ButtonPink = new System.Windows.Forms.Button();
            this.m_ButtonOrange = new System.Windows.Forms.Button();
            this.m_ButtonBlue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.m_ButtonRed.BackColor = System.Drawing.Color.Red;
            this.m_ButtonRed.Location = new System.Drawing.Point(12, 12);
            this.m_ButtonRed.Name = "Red";
            this.m_ButtonRed.Size = new System.Drawing.Size(39, 38);
            this.m_ButtonRed.TabIndex = 0;
            this.m_ButtonRed.UseVisualStyleBackColor = false;
            this.m_ButtonRed.Click += new System.EventHandler(this.WhichColorWasChose);
            // 
            // Aqua
            // 
            this.m_ButtonAqua.BackColor = System.Drawing.Color.Aqua;
            this.m_ButtonAqua.Location = new System.Drawing.Point(68, 12);
            this.m_ButtonAqua.Name = "Aqua";
            this.m_ButtonAqua.Size = new System.Drawing.Size(39, 38);
            this.m_ButtonAqua.TabIndex = 1;
            this.m_ButtonAqua.UseVisualStyleBackColor = false;
            this.m_ButtonAqua.Click += new System.EventHandler(this.WhichColorWasChose);

            // 
            // Purple
            // 
            this.m_ButtonPurple.BackColor = System.Drawing.Color.Purple;
            this.m_ButtonPurple.Location = new System.Drawing.Point(127, 12);
            this.m_ButtonPurple.Name = "Purple";
            this.m_ButtonPurple.Size = new System.Drawing.Size(39, 38);
            this.m_ButtonPurple.TabIndex = 2;
            this.m_ButtonPurple.UseVisualStyleBackColor = false;
            this.m_ButtonPurple.Click += new System.EventHandler(this.WhichColorWasChose);

            // 
            // Green
            // 
            this.m_ButtonGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.m_ButtonGreen.Location = new System.Drawing.Point(182, 12);
            this.m_ButtonGreen.Name = "Green";
            this.m_ButtonGreen.Size = new System.Drawing.Size(39, 38);
            this.m_ButtonGreen.TabIndex = 3;
            this.m_ButtonGreen.UseVisualStyleBackColor = false;
            this.m_ButtonGreen.Click += new System.EventHandler(this.WhichColorWasChose);

            // 
            // DarkGray
            // 
            this.m_ButtonDarkGray.BackColor = System.Drawing.Color.DarkSlateGray;
            this.m_ButtonDarkGray.Location = new System.Drawing.Point(12, 56);
            this.m_ButtonDarkGray.Name = "DarkGray";
            this.m_ButtonDarkGray.Size = new System.Drawing.Size(39, 38);
            this.m_ButtonDarkGray.TabIndex = 4;
            this.m_ButtonDarkGray.UseVisualStyleBackColor = false;
            this.m_ButtonDarkGray.Click += new System.EventHandler(this.WhichColorWasChose);
            // 
            // Pink
            // 
            this.m_ButtonPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.m_ButtonPink.Location = new System.Drawing.Point(68, 56);
            this.m_ButtonPink.Name = "Pink";
            this.m_ButtonPink.Size = new System.Drawing.Size(39, 38);
            this.m_ButtonPink.TabIndex = 5;
            this.m_ButtonPink.UseVisualStyleBackColor = false;
            this.m_ButtonPink.Click += new System.EventHandler(this.WhichColorWasChose);
            // 
            // Orange
            // 
            this.m_ButtonOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.m_ButtonOrange.Location = new System.Drawing.Point(127, 56);
            this.m_ButtonOrange.Name = "Orange";
            this.m_ButtonOrange.Size = new System.Drawing.Size(39, 38);
            this.m_ButtonOrange.TabIndex = 6;
            this.m_ButtonOrange.UseVisualStyleBackColor = false;
            this.m_ButtonOrange.Click += new System.EventHandler(this.WhichColorWasChose);
            // 
            // Blue
            // 
            this.m_ButtonBlue.BackColor = System.Drawing.Color.Blue;
            this.m_ButtonBlue.Location = new System.Drawing.Point(182, 56);
            this.m_ButtonBlue.Name = "Blue";
            this.m_ButtonBlue.Size = new System.Drawing.Size(39, 38);
            this.m_ButtonBlue.TabIndex = 7;
            this.m_ButtonBlue.UseVisualStyleBackColor = false;
            this.m_ButtonBlue.Click += new System.EventHandler(this.WhichColorWasChose);
            // 
            // PickColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 104);
            this.Controls.Add(this.m_ButtonBlue);
            this.Controls.Add(this.m_ButtonOrange);
            this.Controls.Add(this.m_ButtonPink);
            this.Controls.Add(this.m_ButtonDarkGray);
            this.Controls.Add(this.m_ButtonGreen);
            this.Controls.Add(this.m_ButtonPurple);
            this.Controls.Add(this.m_ButtonAqua);
            this.Controls.Add(this.m_ButtonRed);
            this.Name = "PickColor";
            this.Text = "PickColor";
            this.ResumeLayout(false);
        }
        #endregion
    }
}