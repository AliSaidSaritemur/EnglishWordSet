namespace EnglishWordSet.Pages
{
    partial class TurkishWordPage
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
            this.txtInputTurkishWords = new System.Windows.Forms.RichTextBox();
            this.txtOutputTurkishWords = new System.Windows.Forms.RichTextBox();
            this.btnGetTurkishWord = new System.Windows.Forms.Button();
            this.btnConvertTrWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputTurkishWords
            // 
            this.txtInputTurkishWords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInputTurkishWords.Location = new System.Drawing.Point(33, 227);
            this.txtInputTurkishWords.Name = "txtInputTurkishWords";
            this.txtInputTurkishWords.Size = new System.Drawing.Size(397, 286);
            this.txtInputTurkishWords.TabIndex = 2;
            this.txtInputTurkishWords.Text = "";
            // 
            // txtOutputTurkishWords
            // 
            this.txtOutputTurkishWords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutputTurkishWords.Location = new System.Drawing.Point(546, 227);
            this.txtOutputTurkishWords.Name = "txtOutputTurkishWords";
            this.txtOutputTurkishWords.Size = new System.Drawing.Size(397, 286);
            this.txtOutputTurkishWords.TabIndex = 3;
            this.txtOutputTurkishWords.Text = "";
            // 
            // btnGetTurkishWord
            // 
            this.btnGetTurkishWord.Location = new System.Drawing.Point(168, 179);
            this.btnGetTurkishWord.Name = "btnGetTurkishWord";
            this.btnGetTurkishWord.Size = new System.Drawing.Size(127, 29);
            this.btnGetTurkishWord.TabIndex = 4;
            this.btnGetTurkishWord.Text = "Get Words";
            this.btnGetTurkishWord.UseVisualStyleBackColor = true;
            this.btnGetTurkishWord.Click += new System.EventHandler(this.btnGetTurkishWord_Click);
            // 
            // btnConvertTrWords
            // 
            this.btnConvertTrWords.Location = new System.Drawing.Point(446, 132);
            this.btnConvertTrWords.Name = "btnConvertTrWords";
            this.btnConvertTrWords.Size = new System.Drawing.Size(94, 29);
            this.btnConvertTrWords.TabIndex = 5;
            this.btnConvertTrWords.Text = "Convert";
            this.btnConvertTrWords.UseVisualStyleBackColor = true;
            this.btnConvertTrWords.Click += new System.EventHandler(this.btnConvertTrWords_Click);
            // 
            // TurkishWordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 604);
            this.Controls.Add(this.btnConvertTrWords);
            this.Controls.Add(this.btnGetTurkishWord);
            this.Controls.Add(this.txtOutputTurkishWords);
            this.Controls.Add(this.txtInputTurkishWords);
            this.Name = "TurkishWordPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurkishWordPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TurkishWordPage_FormClosing);
            this.Load += new System.EventHandler(this.TurkishWordPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInputTurkishWords;
        private System.Windows.Forms.RichTextBox txtOutputTurkishWords;
        private System.Windows.Forms.Button btnGetTurkishWord;
        private System.Windows.Forms.Button btnConvertTrWords;
    }
}