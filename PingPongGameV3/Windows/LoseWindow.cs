using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGameV3.Windows
{
    public partial class LoseWindow : Form
    {
        public int GameMod { get; set; }
        public LoseWindow(int gameMod, string player)
        {
            InitializeComponent();
            lbLose.Text += player.ToString();
            GameMod = gameMod;
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            if(GameMod == 1)
            {
                SinglePlayer single = new SinglePlayer(1);
                single.Show();
                this.Close();
            }
            if(GameMod == 2)
            {
                TwoPlayer two = new TwoPlayer(1);
                two.Show();
                this.Close();
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            menu.Show();
            this.Close();
        }
    }
}
