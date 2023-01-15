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
    public partial class FormWantsToRestartGame : Form
    {
        public FormWantsToRestartGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.m_DoesUserWantToRestartGame = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.m_DoesUserWantToRestartGame = false;
            this.Close();
        }

        public bool DoesTheUserWantToRestartGame
        {
            get { return m_DoesUserWantToRestartGame; }
        }
    }
}
