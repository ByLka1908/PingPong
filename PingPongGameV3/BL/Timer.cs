using PingPongGameV3.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGameV3.BL
{
    class Timer
    {
        /// <summary>
        /// Скорость во вертекали
        /// </summary>
        public static int SpeedVertical = 2;
        /// <summary>
        /// Скорость по горизонтали
        /// </summary>
        public static int SpeedHorizontal = 2;
        /// <summary>
        /// Счет
        /// </summary>
        public static int score = 0;

        public static int Timers(PictureBox gamePanel, PictureBox ball,
            Panel backGround, System.Windows.Forms.Timer timer, SinglePlayer singlePlayer)
        {
            ball.Left += SpeedHorizontal;
            ball.Top += SpeedVertical; //Запуск мячика
            gamePanel.Left = Cursor.Position.X - (gamePanel.Width / 2);//Движение мыши

            if (ball.Left <= backGround.Left)//Если мяч достиг левой стороны экрана, разворот в право
            {
                SpeedHorizontal *= -1;
            }
            if (ball.Right >= backGround.Right)//Если мяч достиг правой стороны экрана, разворот в лево
            {
                SpeedHorizontal *= -1;
            }
            if (ball.Top <= backGround.Top)//Если мяч достиг вершины экрана, разворот вниз
            {
                SpeedVertical *= -1;
            }
            if (ball.Bottom >= backGround.Bottom)//Если мяч достин низа экрана, проигрыш
            {
                timer.Enabled = false;
                LoseWindow lose = new LoseWindow(1, " Player");
                lose.Show();
                singlePlayer.Visible = false;
                SpeedHorizontal = 2;
                SpeedVertical = 2;
                score = 0;
            }

            if (ball.Bottom >= gamePanel.Top
               && ball.Bottom <= gamePanel.Bottom
               && ball.Left >= gamePanel.Left
               && ball.Right <= gamePanel.Right)//Проверки на соприкосновения мяча с платформой
            {
                SpeedHorizontal += 1;
                SpeedVertical += 1;
                SpeedVertical *= -1;//Меняем направление мяча
                score += 1;
                return score;
            }
            return score;
        }

        public static void Timers(PictureBox playerOne, PictureBox playerTwo, PictureBox ball,
            Panel background, System.Windows.Forms.Timer timer, TwoPlayer twoPlayer)
        {
            ball.Left += SpeedHorizontal;
            ball.Top += SpeedVertical; //Запуск мячика

            if (ball.Left <= background.Left)//Если мяч достиг левой стороны экрана, разворот в право
            {
                SpeedHorizontal *= -1;
            }
            if (ball.Right >= background.Right)//Если мяч достиг правой стороны экрана, разворот в лево
            {
                SpeedHorizontal *= -1;
            }

            if (ball.Top <= background.Top)//Если мяч достин верхушки экрана, игрок 2 проиграл
            {
                timer.Enabled = false;
                LoseWindow lose = new LoseWindow(2, " Two Player\nWin: First Player");
                lose.Show();
                twoPlayer.Visible = false;
                SpeedHorizontal = 2;
                SpeedVertical = 2;
            }
            if (ball.Bottom >= background.Bottom)//Если мяч достин верхушки экрана, игрок 2 проиграл
            {
                timer.Enabled = false;
                LoseWindow lose = new LoseWindow(2, " First Player\nWin: Two Player");
                lose.Show();
                twoPlayer.Visible = false;
                SpeedHorizontal = 2;
                SpeedVertical = 2;
            }

            if (ball.Bottom >= playerOne.Top
               && ball.Bottom <= playerOne.Bottom
               && ball.Left >= playerOne.Left
               && ball.Right <= playerOne.Right)//Проверки на соприкосновения мяча с платформой
            {
                SpeedHorizontal += 1;
                SpeedVertical += 1;
                SpeedVertical *= -1;//Меняем направление мяча
            }

            if (ball.Top <= playerTwo.Bottom
               && ball.Top >= playerTwo.Top
               && ball.Right >= playerTwo.Left
               && ball.Left <= playerTwo.Right)//Проверки на соприкосновения мяча с платформой
            {
                SpeedHorizontal += 1;
                SpeedVertical += 1;
                SpeedVertical *= -1;//Меняем направление мяча
            }

        }
    }
}