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
            this.btnOpenCreatingSentencePage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCreatingSentencePage
            // 
            this.btnOpenCreatingSentencePage.Location = new System.Drawing.Point(26, 29);
            this.btnOpenCreatingSentencePage.Name = "btnOpenCreatingSentencePage";
            this.btnOpenCreatingSentencePage.Size = new System.Drawing.Size(176, 74);
            this.btnOpenCreatingSentencePage.TabIndex = 0;
            this.btnOpenCreatingSentencePage.Text = "Create Sentence";
            this.btnOpenCreatingSentencePage.UseVisualStyleBackColor = true;
            this.btnOpenCreatingSentencePage.Click += new System.EventHandler(this.btnOpenCreatingSentencePage_Click);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 300);
            this.Controls.Add(this.btnOpenCreatingSentencePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GamePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePanel_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCreatingSentencePage;
    }
}