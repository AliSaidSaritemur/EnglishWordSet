namespace EnglishWordSet.Pages.Games
{
    partial class LastLetterGamePage
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
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblrequiredLetter = new System.Windows.Forms.Label();
            this.btnApplyWord = new System.Windows.Forms.Button();
            this.epTextNewWord = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbResetGame = new System.Windows.Forms.PictureBox();
            this.lblSkorTittle = new System.Windows.Forms.Label();
            this.lblScoreBoard = new System.Windows.Forms.Label();
            this.lblGameTimer = new System.Windows.Forms.Label();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pbBackUserPage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epTextNewWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResetGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackUserPage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewWord
            // 
            this.txtNewWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewWord.Location = new System.Drawing.Point(253, 214);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(230, 34);
            this.txtNewWord.TabIndex = 0;
            this.txtNewWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewWord_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Letter Game";
            // 
            // lblrequiredLetter
            // 
            this.lblrequiredLetter.AutoSize = true;
            this.lblrequiredLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrequiredLetter.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblrequiredLetter.Location = new System.Drawing.Point(682, 51);
            this.lblrequiredLetter.Name = "lblrequiredLetter";
            this.lblrequiredLetter.Size = new System.Drawing.Size(64, 73);
            this.lblrequiredLetter.TabIndex = 3;
            this.lblrequiredLetter.Text = "A";
            // 
            // btnApplyWord
            // 
            this.btnApplyWord.BackColor = System.Drawing.Color.White;
            this.btnApplyWord.Location = new System.Drawing.Point(498, 214);
            this.btnApplyWord.Name = "btnApplyWord";
            this.btnApplyWord.Size = new System.Drawing.Size(75, 34);
            this.btnApplyWord.TabIndex = 4;
            this.btnApplyWord.Text = "Next";
            this.btnApplyWord.UseVisualStyleBackColor = false;
            this.btnApplyWord.Click += new System.EventHandler(this.btnApplyWord_Click);
            // 
            // epTextNewWord
            // 
            this.epTextNewWord.ContainerControl = this;
            // 
            // pbResetGame
            // 
            this.pbResetGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbResetGame.Image = global::EnglishWordSet.Properties.Resources.againIcon;
            this.pbResetGame.Location = new System.Drawing.Point(735, 386);
            this.pbResetGame.Name = "pbResetGame";
            this.pbResetGame.Size = new System.Drawing.Size(64, 62);
            this.pbResetGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResetGame.TabIndex = 5;
            this.pbResetGame.TabStop = false;
            this.pbResetGame.Click += new System.EventHandler(this.pbResetGame_Click);
            // 
            // lblSkorTittle
            // 
            this.lblSkorTittle.AutoSize = true;
            this.lblSkorTittle.BackColor = System.Drawing.Color.White;
            this.lblSkorTittle.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSkorTittle.ForeColor = System.Drawing.Color.Brown;
            this.lblSkorTittle.Location = new System.Drawing.Point(0, 411);
            this.lblSkorTittle.Name = "lblSkorTittle";
            this.lblSkorTittle.Size = new System.Drawing.Size(117, 39);
            this.lblSkorTittle.TabIndex = 6;
            this.lblSkorTittle.Text = "Score";
            // 
            // lblScoreBoard
            // 
            this.lblScoreBoard.AutoSize = true;
            this.lblScoreBoard.BackColor = System.Drawing.Color.White;
            this.lblScoreBoard.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScoreBoard.Location = new System.Drawing.Point(111, 411);
            this.lblScoreBoard.Name = "lblScoreBoard";
            this.lblScoreBoard.Size = new System.Drawing.Size(35, 42);
            this.lblScoreBoard.TabIndex = 7;
            this.lblScoreBoard.Text = "0";
            // 
            // lblGameTimer
            // 
            this.lblGameTimer.AutoSize = true;
            this.lblGameTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTimer.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameTimer.Location = new System.Drawing.Point(341, 151);
            this.lblGameTimer.Name = "lblGameTimer";
            this.lblGameTimer.Size = new System.Drawing.Size(53, 37);
            this.lblGameTimer.TabIndex = 8;
            this.lblGameTimer.Text = "60";
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Interval = 1000;
            this.tmrGameTimer.Tick += new System.EventHandler(this.tmrGameTimer_Tick);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnStartGame.Location = new System.Drawing.Point(211, 135);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(362, 192);
            this.btnStartGame.TabIndex = 9;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // pbBackUserPage
            // 
            this.pbBackUserPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBackUserPage.Image = global::EnglishWordSet.Properties.Resources.back;
            this.pbBackUserPage.Location = new System.Drawing.Point(0, 203);
            this.pbBackUserPage.Name = "pbBackUserPage";
            this.pbBackUserPage.Size = new System.Drawing.Size(76, 62);
            this.pbBackUserPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackUserPage.TabIndex = 10;
            this.pbBackUserPage.TabStop = false;
            this.pbBackUserPage.Click += new System.EventHandler(this.pbBackUserPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Best Score :";
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Font = new System.Drawing.Font("Sylfaen", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBestScore.Location = new System.Drawing.Point(134, 51);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(26, 29);
            this.lblBestScore.TabIndex = 12;
            this.lblBestScore.Text = "0";
            // 
            // LastLetterGamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbBackUserPage);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblGameTimer);
            this.Controls.Add(this.lblScoreBoard);
            this.Controls.Add(this.lblSkorTittle);
            this.Controls.Add(this.pbResetGame);
            this.Controls.Add(this.btnApplyWord);
            this.Controls.Add(this.lblrequiredLetter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LastLetterGamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LastLetterGamePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LastLetterGamePage_FormClosing);
            this.Load += new System.EventHandler(this.LastLetterGamePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epTextNewWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResetGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackUserPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrequiredLetter;
        private System.Windows.Forms.Button btnApplyWord;
        private System.Windows.Forms.ErrorProvider epTextNewWord;
        private System.Windows.Forms.PictureBox pbResetGame;
        private System.Windows.Forms.Label lblScoreBoard;
        private System.Windows.Forms.Label lblSkorTittle;
        private System.Windows.Forms.Label lblGameTimer;
        private System.Windows.Forms.Timer tmrGameTimer;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox pbBackUserPage;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Label label2;
    }
}