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
    public partial class TwoPlayer : Form
    {
        public TwoPlayer()
        {
            InitializeComponent();
            OneGamePanel.Top = BackGround.Bottom - (BackGround.Bottom / 10);//Привязка к низу
            TwoGamePanel.Top =BackGround.Top + 15;//Привязка к верху

            OneGamePanel.Visible = false;//Скрываем платформы и мяч
            TwoGamePanel.Visible = false;
            Ball.Visible = false;
        }
        public TwoPlayer(int s)
        {
            InitializeComponent();
            OneGamePanel.Top = BackGround.Bottom - (BackGround.Bottom / 10);//Привязка к низу
            TwoGamePanel.Top = BackGround.Top + 15;//Привязка к верху
        
            #region Убираем label
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            #endregion
            timer.Enabled = true;
        }
        private void KeyDown_Click(object sender, KeyEventArgs e)
        {
            BL.Move.Moves(e, OneGamePanel, TwoGamePanel);
            if(e.KeyCode == Keys.E)
            {
                #region Убираем label
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                #endregion

                OneGamePanel.Visible = true;//Снимаем сокрытие с платформы и мяча
                TwoGamePanel.Visible = true;
                Ball.Visible = true;
                timer.Enabled = true;
            }
            if(e.KeyCode == Keys.Space)
            {
                if(timer.Enabled == true)
                {
                    timer.Enabled = false;
                    lbPause.Visible = true;
                }
                else
                {
                    timer.Enabled = true;
                    lbPause.Visible = false;
                }
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            BL.Timer.Timers(OneGamePanel, TwoGamePanel, Ball,
                BackGround, timer, this);
        }
    }
}
