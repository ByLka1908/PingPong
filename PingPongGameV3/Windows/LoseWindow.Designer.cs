
namespace PingPongGameV3.Windows
{
    partial class LoseWindow
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
            this.lbLose = new System.Windows.Forms.Label();
            this.btRestart = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLose
            // 
            this.lbLose.AutoSize = true;
            this.lbLose.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLose.Location = new System.Drawing.Point(29, 25);
            this.lbLose.Name = "lbLose";
            this.lbLose.Size = new System.Drawing.Size(65, 29);
            this.lbLose.TabIndex = 0;
            this.lbLose.Text = "Lose:";
            // 
            // btRestart
            // 
            this.btRestart.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRestart.Location = new System.Drawing.Point(66, 127);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(150, 35);
            this.btRestart.TabIndex = 1;
            this.btRestart.Text = "Restart";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMenu.Location = new System.Drawing.Point(66, 177);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(150, 35);
            this.btMenu.TabIndex = 2;
            this.btMenu.Text = "Back to Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // LoseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.lbLose);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoseWindow";
            this.Text = "Lose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLose;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Button btMenu;
    }
}