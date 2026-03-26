using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Rock_Paper_scissors_Game
{
    public partial class frmStartGameScreen : Form
    {
        public frmStartGameScreen()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            frmGameScreen frmGame =new frmGameScreen();
            this.Hide();
            frmGame.ShowDialog();
            //frmGame.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAboutMeScreen frmAboutMe = new frmAboutMeScreen();
            frmAboutMe.ShowDialog();
        }
    }
}
