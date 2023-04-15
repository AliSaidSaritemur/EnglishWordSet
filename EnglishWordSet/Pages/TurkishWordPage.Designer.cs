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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInputClean = new System.Windows.Forms.Button();
            this.btnOutputClean = new System.Windows.Forms.Button();
            this.pbBackMainPage = new System.Windows.Forms.PictureBox();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackMainPage)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(330, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Turkish Words Panel";
            // 
            // btnInputClean
            // 
            this.btnInputClean.Location = new System.Drawing.Point(371, 227);
            this.btnInputClean.Name = "btnInputClean";
            this.btnInputClean.Size = new System.Drawing.Size(59, 29);
            this.btnInputClean.TabIndex = 24;
            this.btnInputClean.Text = "Clean";
            this.btnInputClean.UseVisualStyleBackColor = true;
            this.btnInputClean.Click += new System.EventHandler(this.btnInputClean_Click);
            // 
            // btnOutputClean
            // 
            this.btnOutputClean.Location = new System.Drawing.Point(884, 227);
            this.btnOutputClean.Name = "btnOutputClean";
            this.btnOutputClean.Size = new System.Drawing.Size(59, 29);
            this.btnOutputClean.TabIndex = 25;
            this.btnOutputClean.Text = "Clean";
            this.btnOutputClean.UseVisualStyleBackColor = true;
            this.btnOutputClean.Click += new System.EventHandler(this.btnOutputClean_Click);
            // 
            // pbBackMainPage
            // 
            this.pbBackMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBackMainPage.Image = global::EnglishWordSet.Properties.Resources.back;
            this.pbBackMainPage.Location = new System.Drawing.Point(-1, 110);
            this.pbBackMainPage.Name = "pbBackMainPage";
            this.pbBackMainPage.Size = new System.Drawing.Size(78, 61);
            this.pbBackMainPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackMainPage.TabIndex = 26;
            this.pbBackMainPage.TabStop = false;
            this.pbBackMainPage.Click += new System.EventHandler(this.pbBackMainPage_Click);
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnDeleteWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteWord.Location = new System.Drawing.Point(884, -2);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(140, 29);
            this.btnDeleteWord.TabIndex = 27;
            this.btnDeleteWord.Text = "Delete Word";
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            this.btnDeleteWord.Click += new System.EventHandler(this.btnDeleteWord_Click);
            // 
            // TurkishWordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1026, 554);
            this.Controls.Add(this.btnDeleteWord);
            this.Controls.Add(this.pbBackMainPage);
            this.Controls.Add(this.btnOutputClean);
            this.Controls.Add(this.btnInputClean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertTrWords);
            this.Controls.Add(this.btnGetTurkishWord);
            this.Controls.Add(this.txtOutputTurkishWords);
            this.Controls.Add(this.txtInputTurkishWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "TurkishWordPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurkishWordPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TurkishWordPage_FormClosing);
            this.Load += new System.EventHandler(this.TurkishWordPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackMainPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInputTurkishWords;
        private System.Windows.Forms.RichTextBox txtOutputTurkishWords;
        private System.Windows.Forms.Button btnGetTurkishWord;
        private System.Windows.Forms.Button btnConvertTrWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInputClean;
        private System.Windows.Forms.Button btnOutputClean;
        private System.Windows.Forms.PictureBox pbBackMainPage;
        private System.Windows.Forms.Button btnDeleteWord;
    }
}