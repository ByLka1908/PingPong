using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGameV3.BL
{
    class Move
    {
        public static void Moves(KeyEventArgs e, PictureBox gamePanel)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Windows.MenuWindow menu = new Windows.MenuWindow();
                menu.Visible = true;
            }
            if (e.KeyCode == Keys.A)
            {
                gamePanel.Left += -40;
            }
            if (e.KeyCode == Keys.D)
            {
                gamePanel.Left += 40;
            }
        }

        public static void Moves(KeyEventArgs e, PictureBox playerOne, PictureBox playerTwo)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Windows.MenuWindow menu = new Windows.MenuWindow();
                menu.Visible = true; 
            }
            if (e.KeyCode == Keys.A)
            {
                playerOne.Left += -40;
            }
            if (e.KeyCode == Keys.D)
            {
                playerOne.Left += 40;
            }


            if (e.KeyCode == Keys.Left)
            {
                playerTwo.Left += -40;
            }
            if (e.KeyCode == Keys.Right)
            {
                playerTwo.Left += 40;
            }
        }
    }
}
