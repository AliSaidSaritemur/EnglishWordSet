﻿namespace EnglishWordSet.Pages
{
    partial class GamePanel
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
            this.btnOpenCreatingSentencePage = new System.Windows.Forms.Button();
            this.btnOpenLastLetterGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCreatingSentencePage
            // 
            this.btnOpenCreatingSentencePage.BackColor = System.Drawing.Color.Yellow;
            this.btnOpenCreatingSentencePage.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnOpenCreatingSentencePage.Location = new System.Drawing.Point(2, 0);
            this.btnOpenCreatingSentencePage.Name = "btnOpenCreatingSentencePage";
            this.btnOpenCreatingSentencePage.Size = new System.Drawing.Size(316, 297);
            this.btnOpenCreatingSentencePage.TabIndex = 0;
            this.btnOpenCreatingSentencePage.Text = "Create Sentence";
            this.btnOpenCreatingSentencePage.UseVisualStyleBackColor = false;
            this.btnOpenCreatingSentencePage.Click += new System.EventHandler(this.btnOpenCreatingSentencePage_Click);
            // 
            // btnOpenLastLetterGame
            // 
            this.btnOpenLastLetterGame.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOpenLastLetterGame.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnOpenLastLetterGame.Location = new System.Drawing.Point(324, 0);
            this.btnOpenLastLetterGame.Name = "btnOpenLastLetterGame";
            this.btnOpenLastLetterGame.Size = new System.Drawing.Size(338, 297);
            this.btnOpenLastLetterGame.TabIndex = 0;
            this.btnOpenLastLetterGame.Text = "Last Letter";
            this.btnOpenLastLetterGame.UseVisualStyleBackColor = false;
            this.btnOpenLastLetterGame.Click += new System.EventHandler(this.btnOpenLastLetterGame_Click);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 300);
            this.Controls.Add(this.btnOpenLastLetterGame);
            this.Controls.Add(this.btnOpenCreatingSentencePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GamePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePanel_FormClosing);
            this.Load += new System.EventHandler(this.GamePanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCreatingSentencePage;
        private System.Windows.Forms.Button btnOpenLastLetterGame;
    }
}