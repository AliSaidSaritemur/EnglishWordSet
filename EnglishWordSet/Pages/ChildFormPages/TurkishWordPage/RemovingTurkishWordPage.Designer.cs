namespace EnglishWordSet.Pages.ChildFormPages.TurkishWordPage
{
    partial class RemovingTurkishWordPage
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
            this.txtWordToBeRemove = new System.Windows.Forms.TextBox();
            this.btnRemoveWord = new System.Windows.Forms.Button();
            this.prWord = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prWord)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWordToBeRemove
            // 
            this.txtWordToBeRemove.Location = new System.Drawing.Point(30, 31);
            this.txtWordToBeRemove.Name = "txtWordToBeRemove";
            this.txtWordToBeRemove.PlaceholderText = "Word";
            this.txtWordToBeRemove.Size = new System.Drawing.Size(125, 27);
            this.txtWordToBeRemove.TabIndex = 0;
            // 
            // btnRemoveWord
            // 
            this.btnRemoveWord.Location = new System.Drawing.Point(39, 75);
            this.btnRemoveWord.Name = "btnRemoveWord";
            this.btnRemoveWord.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveWord.TabIndex = 1;
            this.btnRemoveWord.Text = "Remove";
            this.btnRemoveWord.UseVisualStyleBackColor = true;
            this.btnRemoveWord.Click += new System.EventHandler(this.btnRemoveWord_Click);
            // 
            // prWord
            // 
            this.prWord.ContainerControl = this;
            // 
            // RemovingTurkishWordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(178, 128);
            this.Controls.Add(this.btnRemoveWord);
            this.Controls.Add(this.txtWordToBeRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RemovingTurkishWordPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RemovingTurkishWordPage";
            ((System.ComponentModel.ISupportInitialize)(this.prWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWordToBeRemove;
        private System.Windows.Forms.Button btnRemoveWord;
        private System.Windows.Forms.ErrorProvider prWord;
    }
}