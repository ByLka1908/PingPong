
namespace PingPongGameV3.Windows
{
    partial class MenuWindow
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
            this.btOnePL = new System.Windows.Forms.Button();
            this.btTwoPL = new System.Windows.Forms.Button();
            this.btExist = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOnePL
            // 
            this.btOnePL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOnePL.Location = new System.Drawing.Point(63, 96);
            this.btOnePL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOnePL.Name = "btOnePL";
            this.btOnePL.Size = new System.Drawing.Size(150, 35);
            this.btOnePL.TabIndex = 0;
            this.btOnePL.Text = "One Player";
            this.btOnePL.UseVisualStyleBackColor = true;
            this.btOnePL.Click += new System.EventHandler(this.btOnePL_Click);
            // 
            // btTwoPL
            // 
            this.btTwoPL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTwoPL.Location = new System.Drawing.Point(63, 145);
            this.btTwoPL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTwoPL.Name = "btTwoPL";
            this.btTwoPL.Size = new System.Drawing.Size(150, 35);
            this.btTwoPL.TabIndex = 1;
            this.btTwoPL.Text = "Two Player";
            this.btTwoPL.UseVisualStyleBackColor = true;
            this.btTwoPL.Click += new System.EventHandler(this.btTwoPL_Click);
            // 
            // btExist
            // 
            this.btExist.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btExist.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.btExist.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExist.Location = new System.Drawing.Point(63, 194);
            this.btExist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExist.Name = "btExist";
            this.btExist.Size = new System.Drawing.Size(150, 35);
            this.btExist.TabIndex = 2;
            this.btExist.Text = "Exist";
            this.btExist.UseVisualStyleBackColor = false;
            this.btExist.Click += new System.EventHandler(this.btExist_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Palatino Linotype", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(21, 11);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(222, 37);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Ping Pong Game";
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btExist);
            this.Controls.Add(this.btTwoPL);
            this.Controls.Add(this.btOnePL);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuWindow";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOnePL;
        private System.Windows.Forms.Button btTwoPL;
        private System.Windows.Forms.Button btExist;
        private System.Windows.Forms.Label lbName;
    }
}