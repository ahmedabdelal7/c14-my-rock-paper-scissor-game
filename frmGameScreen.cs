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
            public short PlayerWonsCount;
            public short CompWonsCount;
            public short DrawCount;

        }
        stGameResults GameResults = new stGameResults();
        enum chChoice
        {
            Rock =1,
            Paper,
            Scissor,
            NoChoice
        }
        enum enRoundResult
        {
            Won =1,
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

        void UpdateGameResults()
        {
            lblPlayerWonsCount.Text = GameResults.PlayerWonsCount.ToString();
            lblCompWonsCount.Text = GameResults.CompWonsCount.ToString();

            lblDrawCount.Text = GameResults.DrawCount.ToString();

            lblRoundCount.Text = (GameResults.PlayerWonsCount +
                GameResults.CompWonsCount +
                GameResults.DrawCount).ToString();
        }

        void UpdateResultLabelColor()
        {
            if (RoundStatus.Result == enRoundResult.Draw)
                lblRoundResult.ForeColor = Color.DodgerBlue;

            else if (RoundStatus.Result == enRoundResult.Won)
                lblRoundResult.ForeColor = Color.LimeGreen;

            else if (RoundStatus.Result == enRoundResult.Lose)
                lblRoundResult.ForeColor = Color.Firebrick;
        }
        string GetChoiceText(chChoice player)
        {
            
            if (player == chChoice.Rock)
                return "Rock";
            else if (player == chChoice.Paper)
                return "Paper";
            else 
                return "Scissor";
        }
        void UpdateRoundStatusMessage(string message)
        {

            lblCompChoice.Text = GetChoiceText(RoundStatus.CompChoice);

            lblPlayerChoice.Text = GetChoiceText(RoundStatus.PlayerChoice);

            lblRoundResult.Text = message;

            //Update Result Color
            UpdateResultLabelColor();    


        }
        enRoundResult RoundResult()
        {
            if (RoundStatus.PlayerChoice == RoundStatus.CompChoice)
                return enRoundResult.Draw;

            if (RoundStatus.PlayerChoice == chChoice.Paper)
            {
                if (RoundStatus.CompChoice == chChoice.Rock)
                    return enRoundResult.Won;

                //Player Choice is Scissor
                else if (RoundStatus.CompChoice == chChoice.Scissor) 
                    return enRoundResult.Lose;

            }if(RoundStatus.PlayerChoice == chChoice.Rock)
            {
                if (RoundStatus.CompChoice == chChoice.Paper)
                    return enRoundResult.Lose;

                //Computer choice is Scissor 
                else
                    return enRoundResult.Won;
            }
            else//Player Choice is Scissor
            {
                if (RoundStatus.CompChoice == chChoice.Paper)
                    return enRoundResult.Won;

                //Comp Choice is Rock
                else 
                    return enRoundResult.Lose;
            }
        }
        void FindWinner()
        {

            switch(RoundResult()){ 
                
                case enRoundResult.Draw:
                    GameResults.DrawCount++;
/*                    GameResults.PlayerWonsCount++;
                    GameResults.CompWonsCount++;*/
                    RoundStatus.Result = enRoundResult.Draw;
                    UpdateRoundStatusMessage("Draw");
                    break;
                case enRoundResult.Won:
                    GameResults.PlayerWonsCount++;
                    RoundStatus.Result = enRoundResult.Won;
                    UpdateRoundStatusMessage("Won");
                    break;
                case enRoundResult.Lose:
                    GameResults.CompWonsCount++;
                    RoundStatus.Result = enRoundResult.Lose;
                    UpdateRoundStatusMessage("Lose");
                    break;                
            }
            UpdateGameResults();
        }
        chChoice MakeChoice(short choice)
        {
            if (choice == (short)chChoice.Rock)
                return chChoice.Rock;
            if (choice == (short)chChoice.Paper)
                return chChoice.Paper;
            else
                return chChoice.Scissor;
        }

        short GetRandomNumber(int from, int to)
        {
            Random random = new Random();
            return (short)random.Next(from, to);

        }

        void StartRound(Button btn)
        {          

            btnResetRounds.Enabled = true;
            RoundStatus.PlayerChoice = MakeChoice(Convert.ToInt16(btn.Tag));
            RoundStatus.CompChoice = MakeChoice(GetRandomNumber(1,4));
            FindWinner();
        }

        void ResetGame()
        {
            btnResetRounds.Enabled = false;
            GameResults.PlayerWonsCount = 0;
            GameResults.CompWonsCount = 0;
            GameResults.DrawCount = 0;

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
