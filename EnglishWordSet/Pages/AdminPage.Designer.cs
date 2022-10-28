
namespace EnglishWordSet
{
    partial class AdminPage
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
            this.btnAddNewWord = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAddNewWord
            // 
            this.btnAddNewWord.Location = new System.Drawing.Point(335, 65);
            this.btnAddNewWord.Name = "btnAddNewWord";
            this.btnAddNewWord.Size = new System.Drawing.Size(134, 29);
            this.btnAddNewWord.TabIndex = 11;
            this.btnAddNewWord.Text = "Add New Words";
            this.btnAddNewWord.UseVisualStyleBackColor = true;
            this.btnAddNewWord.Click += new System.EventHandler(this.btnAddNewWord_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(202, 100);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(397, 286);
            this.txtInput.TabIndex = 10;
            this.txtInput.Text = "";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddNewWord);
            this.Controls.Add(this.txtInput);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewWord;
        private System.Windows.Forms.RichTextBox txtInput;
    }
}