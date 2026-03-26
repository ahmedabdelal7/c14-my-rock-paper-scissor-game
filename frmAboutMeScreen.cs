using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _5_Rock_Paper_scissors_Game
{
    public partial class frmAboutMeScreen : Form
    {
        public frmAboutMeScreen()
        {
            InitializeComponent();
        }

        private void lnkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/ahmedabdelal7",
                UseShellExecute = true
            });
        }

        private void lnkLnkdIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/ahmedabdelal7/",
                UseShellExecute = true
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "mailto:aabdelaal.dev@gmail.com",
                UseShellExecute = true
            });
        }
    }
}
