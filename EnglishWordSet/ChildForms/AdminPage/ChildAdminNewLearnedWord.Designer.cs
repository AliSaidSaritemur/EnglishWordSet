namespace EnglishWordSet.ChildForms.AdminPage
{
    partial class ChildAdminNewLearnedWord
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
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtSentence = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(122, 85);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(125, 27);
            this.txtWord.TabIndex = 0;
            this.txtWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWord_KeyDown);
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(122, 136);
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(197, 57);
            this.txtSentence.TabIndex = 1;
            this.txtSentence.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = " Word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sentence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Meaning";
            // 
            // txtMeaning
            // 
            this.txtMeaning.Location = new System.Drawing.Point(122, 229);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(125, 27);
            this.txtMeaning.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(99, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Submit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adding Learned English Words";
            // 
            // ChildAdminNewLearnedWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.txtWord);
            this.Name = "ChildAdminNewLearnedWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChildAdminNewLearnedWord";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChildAdminNewLearnedWord_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.RichTextBox txtSentence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
    }
}