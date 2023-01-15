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
    public partial class FormGameSettings : Form
    {
        public FormGameSettings()
        {
            InitializeComponent();
        }

        public void CountClicked(object sender, EventArgs e)
        {
            Button theSender = sender as Button;

            m_Count++;
            if (m_Count > 10)
            {
                m_Count = 4;
            }

            theSender.Text = ("Number of chances :" + m_Count);
        }

        public void GameStarted(object sender, EventArgs e)
        {
            m_IsGameStarted = true;
            this.Visible = false;
        }
    }
}
