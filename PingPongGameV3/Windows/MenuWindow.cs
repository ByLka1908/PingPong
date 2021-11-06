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
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void btOnePL_Click(object sender, EventArgs e) 
        {
            SinglePlayer single = new SinglePlayer();
            single.Show();
            this.Visible = false;
        }

        private void btExist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите выйти?", "Выйти", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btTwoPL_Click(object sender, EventArgs e)
        {
            TwoPlayer two = new TwoPlayer();
            two.Show();
            this.Visible = false;
        }
    }
}
