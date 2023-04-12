namespace EnglishWordSet.Pages.Games
{
    partial class CreatingSentence
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
            this.btnStartSentenceGame = new System.Windows.Forms.Button();
            this.lblWord1 = new System.Windows.Forms.Label();
            this.lblWord2 = new System.Windows.Forms.Label();
            this.lblWord3 = new System.Windows.Forms.Label();
            this.lblWord4 = new System.Windows.Forms.Label();
            this.rTBInputSentence = new System.Windows.Forms.RichTextBox();
            this.rTBTranslatedSentence = new System.Windows.Forms.RichTextBox();
            this.btnTestSentence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getLaarnedWordPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartSentenceGame
            // 
            this.btnStartSentenceGame.Location = new System.Drawing.Point(324, 88);
            this.btnStartSentenceGame.Name = "btnStartSentenceGame";
            this.btnStartSentenceGame.Size = new System.Drawing.Size(94, 29);
            this.btnStartSentenceGame.TabIndex = 0;
            this.btnStartSentenceGame.Text = "Change";
            this.btnStartSentenceGame.UseVisualStyleBackColor = true;
            this.btnStartSentenceGame.Click += new System.EventHandler(this.btnStartSentenceGame_Click);
            // 
            // lblWord1
            // 
            this.lblWord1.BackColor = System.Drawing.Color.Yellow;
            this.lblWord1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWord1.Location = new System.Drawing.Point(89, 54);
            this.lblWord1.Name = "lblWord1";
            this.lblWord1.Size = new System.Drawing.Size(221, 25);
            this.lblWord1.TabIndex = 1;
            this.lblWord1.Text = "?";
            this.lblWord1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWord2
            // 
            this.lblWord2.BackColor = System.Drawing.Color.Yellow;
            this.lblWord2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWord2.Location = new System.Drawing.Point(441, 54);
            this.lblWord2.Name = "lblWord2";
            this.lblWord2.Size = new System.Drawing.Size(240, 25);
            this.lblWord2.TabIndex = 2;
            this.lblWord2.Text = "?";
            this.lblWord2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWord3
            // 
            this.lblWord3.BackColor = System.Drawing.Color.Yellow;
            this.lblWord3.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWord3.Location = new System.Drawing.Point(89, 120);
            this.lblWord3.Name = "lblWord3";
            this.lblWord3.Size = new System.Drawing.Size(221, 25);
            this.lblWord3.TabIndex = 3;
            this.lblWord3.Text = "?";
            this.lblWord3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWord4
            // 
            this.lblWord4.BackColor = System.Drawing.Color.Yellow;
            this.lblWord4.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWord4.Location = new System.Drawing.Point(441, 120);
            this.lblWord4.Name = "lblWord4";
            this.lblWord4.Size = new System.Drawing.Size(240, 25);
            this.lblWord4.TabIndex = 4;
            this.lblWord4.Text = "?";
            this.lblWord4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rTBInputSentence
            // 
            this.rTBInputSentence.Location = new System.Drawing.Point(12, 177);
            this.rTBInputSentence.Name = "rTBInputSentence";
            this.rTBInputSentence.Size = new System.Drawing.Size(298, 120);
            this.rTBInputSentence.TabIndex = 5;
            this.rTBInputSentence.Text = "";
            // 
            // rTBTranslatedSentence
            // 
            this.rTBTranslatedSentence.Location = new System.Drawing.Point(441, 177);
            this.rTBTranslatedSentence.Name = "rTBTranslatedSentence";
            this.rTBTranslatedSentence.Size = new System.Drawing.Size(307, 120);
            this.rTBTranslatedSentence.TabIndex = 6;
            this.rTBTranslatedSentence.Text = "";
            // 
            // btnTestSentence
            // 
            this.btnTestSentence.Location = new System.Drawing.Point(324, 217);
            this.btnTestSentence.Name = "btnTestSentence";
            this.btnTestSentence.Size = new System.Drawing.Size(94, 29);
            this.btnTestSentence.TabIndex = 7;
            this.btnTestSentence.Text = "Test";
            this.btnTestSentence.UseVisualStyleBackColor = true;
            this.btnTestSentence.Click += new System.EventHandler(this.btnTestSentence_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "<---------->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "<---------->";
            // 
            // getLaarnedWordPage
            // 
            this.getLaarnedWordPage.Location = new System.Drawing.Point(605, 3);
            this.getLaarnedWordPage.Name = "getLaarnedWordPage";
            this.getLaarnedWordPage.Size = new System.Drawing.Size(160, 29);
            this.getLaarnedWordPage.TabIndex = 13;
            this.getLaarnedWordPage.Text = "Get Word Sentence";
            this.getLaarnedWordPage.UseVisualStyleBackColor = true;
            this.getLaarnedWordPage.Click += new System.EventHandler(this.getLaarnedWordPage_Click);
            // 
            // CreatingSentence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 309);
            this.Controls.Add(this.getLaarnedWordPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestSentence);
            this.Controls.Add(this.rTBTranslatedSentence);
            this.Controls.Add(this.rTBInputSentence);
            this.Controls.Add(this.lblWord4);
            this.Controls.Add(this.lblWord3);
            this.Controls.Add(this.lblWord2);
            this.Controls.Add(this.lblWord1);
            this.Controls.Add(this.btnStartSentenceGame);
            this.MaximizeBox = false;
            this.Name = "CreatingSentence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatingSentence";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreatingSentence_FormClosing);
            this.Load += new System.EventHandler(this.CreatingSentence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSentenceGame;
        private System.Windows.Forms.Label lblWord1;
        private System.Windows.Forms.Label lblWord2;
        private System.Windows.Forms.Label lblWord3;
        private System.Windows.Forms.Label lblWord4;
        private System.Windows.Forms.RichTextBox rTBInputSentence;
        private System.Windows.Forms.RichTextBox rTBTranslatedSentence;
        private System.Windows.Forms.Button btnTestSentence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getLaarnedWordPage;
    }
}