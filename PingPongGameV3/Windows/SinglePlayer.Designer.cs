
namespace PingPongGameV3
{
    partial class SinglePlayer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackGround = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.GamePanel = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPause = new System.Windows.Forms.Label();
            this.BackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.Controls.Add(this.lbPause);
            this.BackGround.Controls.Add(this.label7);
            this.BackGround.Controls.Add(this.label6);
            this.BackGround.Controls.Add(this.label5);
            this.BackGround.Controls.Add(this.label4);
            this.BackGround.Controls.Add(this.label2);
            this.BackGround.Controls.Add(this.label1);
            this.BackGround.Controls.Add(this.lbResult);
            this.BackGround.Controls.Add(this.Ball);
            this.BackGround.Controls.Add(this.GamePanel);
            this.BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(800, 450);
            this.BackGround.TabIndex = 0;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Arial Black", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResult.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbResult.Location = new System.Drawing.Point(12, 9);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(125, 32);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "Result: 0";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Blue;
            this.Ball.Location = new System.Drawing.Point(333, 199);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(15, 15);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Red;
            this.GamePanel.Location = new System.Drawing.Point(172, 383);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(133, 10);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(198, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вы играете в PingPong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(198, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Управление платформой Мышью";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(198, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Нажмите на Space для паузы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(198, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Нажмите на Escape для выхода в меню";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(198, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Нажмите на E для начала игры";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(198, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Приятной игры";
            // 
            // lbPause
            // 
            this.lbPause.AutoSize = true;
            this.lbPause.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPause.Location = new System.Drawing.Point(364, 192);
            this.lbPause.Name = "lbPause";
            this.lbPause.Size = new System.Drawing.Size(54, 22);
            this.lbPause.TabIndex = 10;
            this.lbPause.Text = "Пауза";
            this.lbPause.Visible = false;
            // 
            // SinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackGround);
            this.Name = "SinglePlayer";
            this.Text = "PingPong(Один игрок)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.BackGround.ResumeLayout(false);
            this.BackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGround;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox GamePanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPause;
    }
}

