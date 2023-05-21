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
            ((System.ComponentModel.ISupportInitialize)(this.epTextNewWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResetGame)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewWord
            // 
            this.txtNewWord.Location = new System.Drawing.Point(262, 222);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(230, 27);
            this.txtNewWord.TabIndex = 0;
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
            this.btnApplyWord.Location = new System.Drawing.Point(498, 220);
            this.btnApplyWord.Name = "btnApplyWord";
            this.btnApplyWord.Size = new System.Drawing.Size(69, 29);
            this.btnApplyWord.TabIndex = 4;
            this.btnApplyWord.Text = "Next";
            this.btnApplyWord.UseVisualStyleBackColor = true;
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
            // LastLetterGamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}