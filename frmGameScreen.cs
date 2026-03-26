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
    public partial class frmGameScreen : Form
    {
        public frmGameScreen()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.BlanchedAlmond;
            Pen pen = new Pen(color);
            pen.Width = 1;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;

            e.Graphics.DrawLine(pen, 630, 120, 630, 405);
            e.Graphics.DrawLine(pen, 630, 120, 865, 120);
            e.Graphics.DrawLine(pen, 865, 120, 865, 405);
            e.Graphics.DrawLine(pen, 630, 405, 865, 405);
            e.Graphics.DrawLine(pen, 630, 185, 865, 185);
        }

/*        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = (e.X + " , " +  (e.Y) );
        }
*/

        struct stGameResults
        {
            public short PlayerWinsCount;
            public short CompWonsCount;
            public short DrawCount;

        }
        stGameResults GameResults = new stGameResults();
        enum chChoice
        {
            Rock,
            Paper,
            Scissor
        }
        enum enRoundResult
        {
            Win =1,
            Lose,
            Draw
        }

        struct stRoundStatus
        {
            public chChoice PlayerChoice;
            public chChoice CompChoice;
            public enRoundResult Result;
        }

        stRoundStatus RoundStatus = new stRoundStatus();

        //-------Those Function For UI---------
        void UpdateResultLabelColor()
        {
            if (RoundStatus.Result == enRoundResult.Draw)
                lblRoundResult.ForeColor = Color.DodgerBlue;

            else if (RoundStatus.Result == enRoundResult.Win)
                lblRoundResult.ForeColor = Color.LimeGreen;

            else if (RoundStatus.Result == enRoundResult.Lose)
                lblRoundResult.ForeColor = Color.Firebrick;
        }
        void UpdateRoundStatusMessage()
        {

            lblCompChoice.Text = RoundStatus.CompChoice.ToString();

            lblPlayerChoice.Text = RoundStatus.PlayerChoice.ToString();

            lblRoundResult.Text = RoundStatus.Result.ToString();

            //Update Result Color
            UpdateResultLabelColor();

        }
        void UpdateGameResults()
        {
            lblPlayerWinsCount.Text = GameResults.PlayerWinsCount.ToString();

            lblCompWonsCount.Text = GameResults.CompWonsCount.ToString();

            lblDrawCount.Text = GameResults.DrawCount.ToString();

            lblRoundCount.Text = (GameResults.PlayerWinsCount +
                GameResults.CompWonsCount +
                GameResults.DrawCount).ToString();
        }
        void UpdateScreenInformation()
        {
            UpdateGameResults();
            UpdateRoundStatusMessage();

        }
        //-------------------------------------
        enRoundResult RoundResult(chChoice player, chChoice comp)
        {
            if (player == comp)
                return enRoundResult.Draw;

            if ((player == chChoice.Rock && comp == chChoice.Scissor) ||
                (player == chChoice.Paper && comp == chChoice.Rock) ||
                (player == chChoice.Scissor && comp == chChoice.Paper))
                return enRoundResult.Win;

            return enRoundResult.Lose;
        }
        void PlayRound()
        {
            RoundStatus.Result = RoundResult(RoundStatus.PlayerChoice, RoundStatus.CompChoice);

            enRoundResult result = RoundStatus.Result;

            if (result == enRoundResult.Draw)
            {
                GameResults.DrawCount++;//draw
                return;
            }
            if(result == enRoundResult.Win)
            {
                GameResults.PlayerWinsCount++;//win
                return;
            }
            else
                GameResults.CompWonsCount++; //lose    
        }
        Random random = new Random();
        chChoice GetRandomComputerChoice()
        {
            return (chChoice)random.Next(0, 3);
        }
        chChoice GetPlayerChoiceFromTag(Button btn)
        {
            return (chChoice)Enum.Parse(typeof(chChoice), btn.Tag.ToString());
        }
        void StartRound(Button btn)
        {          

            btnResetRounds.Enabled = true;

            RoundStatus.PlayerChoice = GetPlayerChoiceFromTag(btn);

            RoundStatus.CompChoice = GetRandomComputerChoice();

            //find round result and update GamesValues
            PlayRound();
            
            //Update Screen Information
            UpdateScreenInformation();
        }

        void ResetGame()
        {
            btnResetRounds.Enabled = false;
            GameResults.PlayerWinsCount = 0;
            GameResults.CompWonsCount = 0;
            GameResults.DrawCount = 0;
           
            //Resete Game Result
            UpdateGameResults();

            lblRoundResult.Text = "";
            lblCompChoice.Text = "";
            lblPlayerChoice.Text = "";

        }

        private void btn_Click(object sender, EventArgs e)
        {
            StartRound((Button)sender);
        }
        private void btnResetRounds_Click(object sender, EventArgs e)
        {
            ResetGame();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
