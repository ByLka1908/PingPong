
namespace PingPongGameV3.Windows
{
    partial class TwoPlayer
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackGround = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TwoGamePanel = new System.Windows.Forms.PictureBox();
            this.OneGamePanel = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbPause = new System.Windows.Forms.Label();
            this.BackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TwoGamePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneGamePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.Controls.Add(this.lbPause);
            this.BackGround.Controls.Add(this.label8);
            this.BackGround.Controls.Add(this.label7);
            this.BackGround.Controls.Add(this.label6);
            this.BackGround.Controls.Add(this.label5);
            this.BackGround.Controls.Add(this.label4);
            this.BackGround.Controls.Add(this.label3);
            this.BackGround.Controls.Add(this.label2);
            this.BackGround.Controls.Add(this.label1);
            this.BackGround.Controls.Add(this.TwoGamePanel);
            this.BackGround.Controls.Add(this.OneGamePanel);
            this.BackGround.Controls.Add(this.Ball);
            this.BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(800, 450);
            this.BackGround.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(199, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Нажмите на E для старта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(199, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Приятной игры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(199, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Two Player вверху, управление стрелки вправо, влево";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(199, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "First Player внизу, управление (A,D)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(199, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Нажмите Space для паузы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(199, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Нажмите Escape для выхода в меню";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(199, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Если мяч залетит за вашу сторону, вы проиграли";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вы играете в игру  PingPong";
            // 
            // TwoGamePanel
            // 
            this.TwoGamePanel.BackColor = System.Drawing.Color.Red;
            this.TwoGamePanel.Location = new System.Drawing.Point(261, 21);
            this.TwoGamePanel.Name = "TwoGamePanel";
            this.TwoGamePanel.Size = new System.Drawing.Size(133, 10);
            this.TwoGamePanel.TabIndex = 4;
            this.TwoGamePanel.TabStop = false;
            // 
            // OneGamePanel
            // 
            this.OneGamePanel.BackColor = System.Drawing.Color.Red;
            this.OneGamePanel.Location = new System.Drawing.Point(275, 418);
            this.OneGamePanel.Name = "OneGamePanel";
            this.OneGamePanel.Size = new System.Drawing.Size(133, 10);
            this.OneGamePanel.TabIndex = 3;
            this.OneGamePanel.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Blue;
            this.Ball.Location = new System.Drawing.Point(393, 218);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(15, 15);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbPause
            // 
            this.lbPause.AutoSize = true;
            this.lbPause.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPause.Location = new System.Drawing.Point(345, 198);
            this.lbPause.Name = "lbPause";
            this.lbPause.Size = new System.Drawing.Size(54, 22);
            this.lbPause.TabIndex = 13;
            this.lbPause.Text = "Пауза";
            this.lbPause.Visible = false;
            // 
            // TwoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackGround);
            this.Name = "TwoPlayer";
            this.Text = "PingPong(Два игрока)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Click);
            this.BackGround.ResumeLayout(false);
            this.BackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TwoGamePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneGamePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGround;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox TwoGamePanel;
        private System.Windows.Forms.PictureBox OneGamePanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPause;
    }
}