namespace EnglishWordSet.Pages
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
            this.btnOpenLastLaterGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenLastLaterGame
            // 
            this.btnOpenLastLaterGame.Location = new System.Drawing.Point(21, 21);
            this.btnOpenLastLaterGame.Name = "btnOpenLastLaterGame";
            this.btnOpenLastLaterGame.Size = new System.Drawing.Size(210, 82);
            this.btnOpenLastLaterGame.TabIndex = 0;
            this.btnOpenLastLaterGame.Text = "Last Letter";
            this.btnOpenLastLaterGame.UseVisualStyleBackColor = true;
            this.btnOpenLastLaterGame.Click += new System.EventHandler(this.btnOpenLastLaterGame_Click);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 300);
            this.Controls.Add(this.btnOpenLastLaterGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GamePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePanel_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenLastLaterGame;
    }
}