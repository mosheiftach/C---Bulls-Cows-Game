﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    static class Program
    {
        [STAThread]
        public static void Main()
        {
            GameController.StartGame();
        }
    }
}
