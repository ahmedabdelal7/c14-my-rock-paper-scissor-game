namespace _5_Rock_Paper_scissors_Game
{
    partial class frmGameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlayerWinsCount = new System.Windows.Forms.Label();
            this.lblCompWonsCount = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.btnResetRounds = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRoundResult = new System.Windows.Forms.Label();
            this.lblCompChoice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDrawCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRoundCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(354, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rock-Paper-Scissor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(236, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chose Your Weapen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(872, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(889, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "You";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label5.Location = new System.Drawing.Point(889, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Comp";
            // 
            // lblPlayerWinsCount
            // 
            this.lblPlayerWinsCount.AutoSize = true;
            this.lblPlayerWinsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerWinsCount.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWinsCount.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblPlayerWinsCount.Location = new System.Drawing.Point(1049, 318);
            this.lblPlayerWinsCount.Name = "lblPlayerWinsCount";
            this.lblPlayerWinsCount.Size = new System.Drawing.Size(40, 36);
            this.lblPlayerWinsCount.TabIndex = 5;
            this.lblPlayerWinsCount.Tag = "0";
            this.lblPlayerWinsCount.Text = "0";
            // 
            // lblCompWonsCount
            // 
            this.lblCompWonsCount.AutoSize = true;
            this.lblCompWonsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCompWonsCount.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompWonsCount.ForeColor = System.Drawing.Color.Magenta;
            this.lblCompWonsCount.Location = new System.Drawing.Point(1052, 380);
            this.lblCompWonsCount.Name = "lblCompWonsCount";
            this.lblCompWonsCount.Size = new System.Drawing.Size(40, 36);
            this.lblCompWonsCount.TabIndex = 6;
            this.lblCompWonsCount.Tag = "0";
            this.lblCompWonsCount.Text = "0";
            // 
            // btnRock
            // 
            this.btnRock.AutoSize = true;
            this.btnRock.BackColor = System.Drawing.Color.Transparent;
            this.btnRock.BackgroundImage = global::_5_Rock_Paper_scissors_Game.Properties.Resources.rock;
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnRock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRock.Location = new System.Drawing.Point(130, 246);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(185, 165);
            this.btnRock.TabIndex = 7;
            this.btnRock.Tag = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.AutoSize = true;
            this.btnPaper.BackColor = System.Drawing.Color.Transparent;
            this.btnPaper.BackgroundImage = global::_5_Rock_Paper_scissors_Game.Properties.Resources.paper;
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaper.Location = new System.Drawing.Point(321, 246);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(185, 165);
            this.btnPaper.TabIndex = 8;
            this.btnPaper.Tag = "Paper";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.AutoSize = true;
            this.btnScissor.BackColor = System.Drawing.Color.Transparent;
            this.btnScissor.BackgroundImage = global::_5_Rock_Paper_scissors_Game.Properties.Resources.scissors;
            this.btnScissor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScissor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScissor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnScissor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnScissor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScissor.Location = new System.Drawing.Point(512, 246);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(185, 165);
            this.btnScissor.TabIndex = 9;
            this.btnScissor.Tag = "Scissor";
            this.btnScissor.UseVisualStyleBackColor = false;
            this.btnScissor.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnResetRounds
            // 
            this.btnResetRounds.AutoSize = true;
            this.btnResetRounds.BackColor = System.Drawing.Color.Green;
            this.btnResetRounds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetRounds.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnResetRounds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetRounds.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetRounds.ForeColor = System.Drawing.Color.White;
            this.btnResetRounds.Location = new System.Drawing.Point(906, 532);
            this.btnResetRounds.Name = "btnResetRounds";
            this.btnResetRounds.Size = new System.Drawing.Size(165, 78);
            this.btnResetRounds.TabIndex = 10;
            this.btnResetRounds.Text = "Reset Rounds";
            this.btnResetRounds.UseVisualStyleBackColor = false;
            this.btnResetRounds.Click += new System.EventHandler(this.btnResetRounds_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblResult.Location = new System.Drawing.Point(599, 486);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(122, 35);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Result";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(101, 575);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 35);
            this.label8.TabIndex = 13;
            this.label8.Text = "Comp Choose";
            // 
            // lblRoundResult
            // 
            this.lblRoundResult.AutoSize = true;
            this.lblRoundResult.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundResult.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundResult.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblRoundResult.Location = new System.Drawing.Point(596, 563);
            this.lblRoundResult.Name = "lblRoundResult";
            this.lblRoundResult.Size = new System.Drawing.Size(140, 51);
            this.lblRoundResult.TabIndex = 11;
            this.lblRoundResult.Text = "what";
            // 
            // lblCompChoice
            // 
            this.lblCompChoice.AutoSize = true;
            this.lblCompChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblCompChoice.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompChoice.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblCompChoice.Location = new System.Drawing.Point(358, 575);
            this.lblCompChoice.Name = "lblCompChoice";
            this.lblCompChoice.Size = new System.Drawing.Size(124, 35);
            this.lblCompChoice.TabIndex = 14;
            this.lblCompChoice.Text = "Choice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(886, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Draw";
            // 
            // lblDrawCount
            // 
            this.lblDrawCount.AutoSize = true;
            this.lblDrawCount.BackColor = System.Drawing.Color.Transparent;
            this.lblDrawCount.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDrawCount.Location = new System.Drawing.Point(1052, 443);
            this.lblDrawCount.Name = "lblDrawCount";
            this.lblDrawCount.Size = new System.Drawing.Size(40, 36);
            this.lblDrawCount.TabIndex = 16;
            this.lblDrawCount.Tag = "0";
            this.lblDrawCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(872, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 37);
            this.label9.TabIndex = 17;
            this.label9.Text = "Round";
            // 
            // lblRoundCount
            // 
            this.lblRoundCount.AutoSize = true;
            this.lblRoundCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundCount.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundCount.ForeColor = System.Drawing.Color.Green;
            this.lblRoundCount.Location = new System.Drawing.Point(1060, 167);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(43, 46);
            this.lblRoundCount.TabIndex = 18;
            this.lblRoundCount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(101, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 35);
            this.label10.TabIndex = 19;
            this.label10.Text = "You Choose";
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChoice.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblPlayerChoice.Location = new System.Drawing.Point(358, 486);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(124, 35);
            this.lblPlayerChoice.TabIndex = 20;
            this.lblPlayerChoice.Text = "Choice";
            // 
            // frmGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1229, 699);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPlayerChoice);
            this.Controls.Add(this.lblRoundCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDrawCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCompChoice);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRoundResult);
            this.Controls.Add(this.btnResetRounds);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblCompWonsCount);
            this.Controls.Add(this.lblPlayerWinsCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock-Paper-Scissor Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlayerWinsCount;
        private System.Windows.Forms.Label lblCompWonsCount;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button btnResetRounds;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRoundResult;
        private System.Windows.Forms.Label lblCompChoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDrawCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRoundCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPlayerChoice;
    }
}

