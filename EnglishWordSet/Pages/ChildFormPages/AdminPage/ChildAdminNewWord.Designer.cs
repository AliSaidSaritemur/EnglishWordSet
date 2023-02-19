namespace EnglishWordSet
{
    partial class ChildAdminNewWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildAdminNewWord));
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.imgTrash = new System.Windows.Forms.PictureBox();
            this.prWords = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGetRandomWord = new System.Windows.Forms.Button();
            this.txtToBeGEttingRandomWordCount = new System.Windows.Forms.TextBox();
            this.prToken = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgTrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prToken)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.txtInput.Location = new System.Drawing.Point(51, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(254, 165);
            this.txtInput.TabIndex = 13;
            this.txtInput.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Location = new System.Drawing.Point(111, 205);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 76);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // imgTrash
            // 
            this.imgTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTrash.Image = ((System.Drawing.Image)(resources.GetObject("imgTrash.Image")));
            this.imgTrash.Location = new System.Drawing.Point(311, 259);
            this.imgTrash.Name = "imgTrash";
            this.imgTrash.Size = new System.Drawing.Size(59, 62);
            this.imgTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTrash.TabIndex = 14;
            this.imgTrash.TabStop = false;
            this.imgTrash.Click += new System.EventHandler(this.imgTrash_Click);
            // 
            // prWords
            // 
            this.prWords.ContainerControl = this;
            // 
            // btnGetRandomWord
            // 
            this.btnGetRandomWord.Location = new System.Drawing.Point(217, 3);
            this.btnGetRandomWord.Name = "btnGetRandomWord";
            this.btnGetRandomWord.Size = new System.Drawing.Size(88, 25);
            this.btnGetRandomWord.TabIndex = 15;
            this.btnGetRandomWord.Text = "Random";
            this.btnGetRandomWord.UseVisualStyleBackColor = true;
            this.btnGetRandomWord.Click += new System.EventHandler(this.btnGetRandomWord_Click);
            // 
            // txtToBeGEttingRandomWordCount
            // 
            this.txtToBeGEttingRandomWordCount.Location = new System.Drawing.Point(311, 3);
            this.txtToBeGEttingRandomWordCount.Name = "txtToBeGEttingRandomWordCount";
            this.txtToBeGEttingRandomWordCount.Size = new System.Drawing.Size(36, 27);
            this.txtToBeGEttingRandomWordCount.TabIndex = 17;
            this.txtToBeGEttingRandomWordCount.Text = "0";
            this.txtToBeGEttingRandomWordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToBeGEttingRandomWordCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToBeGEttingRandomWordCount_KeyPress);
            // 
            // prToken
            // 
            this.prToken.ContainerControl = this;
            // 
            // ChildAdminNewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(367, 323);
            this.Controls.Add(this.txtToBeGEttingRandomWordCount);
            this.Controls.Add(this.btnGetRandomWord);
            this.Controls.Add(this.imgTrash);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInput);
            this.Name = "ChildAdminNewWord";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChildAdminNewWord";
            ((System.ComponentModel.ISupportInitialize)(this.imgTrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prToken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;
        internal System.Windows.Forms.PictureBox imgTrash;
        private System.Windows.Forms.ErrorProvider prWords;
        private System.Windows.Forms.Button btnGetRandomWord;
        private System.Windows.Forms.TextBox txtToBeGEttingRandomWordCount;
        private System.Windows.Forms.ErrorProvider prToken;
    }
}