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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTokenAmount = new System.Windows.Forms.Label();
            this.getMeaningWithMark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prToken)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.txtInput.Location = new System.Drawing.Point(51, 53);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(293, 198);
            this.txtInput.TabIndex = 13;
            this.txtInput.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Location = new System.Drawing.Point(124, 258);
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
            this.imgTrash.Location = new System.Drawing.Point(381, 272);
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
            this.btnGetRandomWord.BackColor = System.Drawing.Color.Wheat;
            this.btnGetRandomWord.Location = new System.Drawing.Point(273, 9);
            this.btnGetRandomWord.Name = "btnGetRandomWord";
            this.btnGetRandomWord.Size = new System.Drawing.Size(102, 33);
            this.btnGetRandomWord.TabIndex = 15;
            this.btnGetRandomWord.Text = "Random";
            this.btnGetRandomWord.UseVisualStyleBackColor = false;
            this.btnGetRandomWord.Click += new System.EventHandler(this.btnGetRandomWord_Click);
            // 
            // txtToBeGEttingRandomWordCount
            // 
            this.txtToBeGEttingRandomWordCount.Location = new System.Drawing.Point(381, 12);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Token :";
            // 
            // lblTokenAmount
            // 
            this.lblTokenAmount.AutoSize = true;
            this.lblTokenAmount.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTokenAmount.Location = new System.Drawing.Point(73, 12);
            this.lblTokenAmount.Name = "lblTokenAmount";
            this.lblTokenAmount.Size = new System.Drawing.Size(20, 21);
            this.lblTokenAmount.TabIndex = 19;
            this.lblTokenAmount.Text = "0";
            // 
            // getMeaningWithMark
            // 
            this.getMeaningWithMark.BackColor = System.Drawing.Color.Wheat;
            this.getMeaningWithMark.Location = new System.Drawing.Point(350, 96);
            this.getMeaningWithMark.Name = "getMeaningWithMark";
            this.getMeaningWithMark.Size = new System.Drawing.Size(75, 35);
            this.getMeaningWithMark.TabIndex = 20;
            this.getMeaningWithMark.Text = "Meannig";
            this.getMeaningWithMark.UseVisualStyleBackColor = false;
            this.getMeaningWithMark.Click += new System.EventHandler(this.getMeaningWithMark_Click);
            // 
            // ChildAdminNewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(436, 337);
            this.Controls.Add(this.getMeaningWithMark);
            this.Controls.Add(this.lblTokenAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToBeGEttingRandomWordCount);
            this.Controls.Add(this.btnGetRandomWord);
            this.Controls.Add(this.imgTrash);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChildAdminNewWord";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChildAdminNewWord";
            this.Load += new System.EventHandler(this.ChildAdminNewWord_Load);
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
        private System.Windows.Forms.Label lblTokenAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getMeaningWithMark;
    }
}