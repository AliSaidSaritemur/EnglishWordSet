namespace EnglishWordSet.Pages.ChildFormPages.AdminPage
{
    partial class TrashBox
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
            this.rtbTrashWords = new System.Windows.Forms.RichTextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCleanWrongWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbTrashWords
            // 
            this.rtbTrashWords.Location = new System.Drawing.Point(66, 38);
            this.rtbTrashWords.Name = "rtbTrashWords";
            this.rtbTrashWords.Size = new System.Drawing.Size(370, 333);
            this.rtbTrashWords.TabIndex = 0;
            this.rtbTrashWords.Text = "";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(268, 406);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(94, 29);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "SaveChanges";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCleanWrongWords
            // 
            this.btnCleanWrongWords.Location = new System.Drawing.Point(125, 406);
            this.btnCleanWrongWords.Name = "btnCleanWrongWords";
            this.btnCleanWrongWords.Size = new System.Drawing.Size(94, 29);
            this.btnCleanWrongWords.TabIndex = 2;
            this.btnCleanWrongWords.Text = "Clean";
            this.btnCleanWrongWords.UseVisualStyleBackColor = true;
            this.btnCleanWrongWords.Click += new System.EventHandler(this.btnCleanWrongWords_Click);
            // 
            // TrashBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.btnCleanWrongWords);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.rtbTrashWords);
            this.Name = "TrashBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrashBox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrashBox_FormClosed);
            this.Load += new System.EventHandler(this.TrashBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTrashWords;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCleanWrongWords;
    }
}