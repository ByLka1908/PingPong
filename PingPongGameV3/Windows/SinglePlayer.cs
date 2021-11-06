using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGameV3
{
    public partial class SinglePlayer : Form
    {
        public SinglePlayer()
        {
            InitializeComponent();
            GamePanel.Visible = false;//Скрываем платформу, мяч и счетчик
            Ball.Visible = false;
            lbResult.Visible = false;

            GamePanel.Top = BackGround.Bottom - (BackGround.Bottom / 10);//Привязка к низу          

        }
        public SinglePlayer(int s)
        {
            InitializeComponent();

            #region Скрываем Label
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            #endregion

            timer.Enabled = true;//Запуск таймера
            GamePanel.Top = BackGround.Bottom - (BackGround.Bottom / 10);//Привязка к низу          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            BL.Move.Moves(e, GamePanel);
            if(e.KeyCode == Keys.E)
            {
                #region Скрываем Label
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                #endregion

                GamePanel.Visible = true;//Снимаем скорытие с платформы и т.д
                Ball.Visible = true;
                lbResult.Visible = true;

                timer.Enabled = true;//Запуск таймера
            }
            if (e.KeyCode == Keys.Space)
            {
                if (timer.Enabled == true)
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
            int score = BL.Timer.Timers(GamePanel, Ball, BackGround, timer, this);
            lbResult.Text = "Result: " + score.ToString();          
        }
    }
}
