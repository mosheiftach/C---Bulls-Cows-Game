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
    public partial class FormPickColor : Form
    {
        public FormPickColor()
        {
            InitializeComponent();
        }
        private void WhichColorWasChose(object sender, EventArgs e)
        {
            Button theSender = sender as Button;

            if (theSender == this.m_ButtonRed)
            {
                this.m_ChoosenColor = this.m_ButtonRed;
                this.m_ColorWasChose = true;
            }
            else if (theSender == this.m_ButtonBlue)
            {
                this.m_ChoosenColor = this.m_ButtonBlue;
                this.m_ColorWasChose = true;
            }
            else if (theSender == this.m_ButtonAqua)
            {
                this.m_ChoosenColor = this.m_ButtonAqua;
                this.m_ColorWasChose = true;
            }
            else if (theSender == this.m_ButtonDarkGray)
            {
                this.m_ChoosenColor = this.m_ButtonDarkGray;
                this.m_ColorWasChose = true;
            }
            else if (theSender == this.m_ButtonGreen)
            {
                this.m_ChoosenColor = this.m_ButtonGreen;
                this.m_ColorWasChose = true;
            }
            else if (theSender == this.m_ButtonOrange)
            {
                this.m_ChoosenColor = this.m_ButtonOrange;
                this.m_ColorWasChose = true;
            }
            else if (theSender == this.m_ButtonPink)
            {
                this.m_ChoosenColor = this.m_ButtonPink;
                this.m_ColorWasChose = true;
            }
            else if (theSender == this.m_ButtonPurple)
            {
                this.m_ChoosenColor = this.m_ButtonPurple;
                this.m_ColorWasChose = true;
            }

            this.Close();
        }
    }
}
