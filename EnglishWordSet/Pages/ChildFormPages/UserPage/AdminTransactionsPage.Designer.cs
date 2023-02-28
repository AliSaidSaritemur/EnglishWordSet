namespace EnglishWordSet.Pages.ChildFormPages.UserPage
{
    partial class AdminTransactionsPage
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
            this.btnAddRandomWordtoDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRandomWordToBeAddCount = new System.Windows.Forms.TextBox();
            this.prAddRandomWords = new System.Windows.Forms.ErrorProvider(this.components);
            this.pBarAddingRandomWords = new System.Windows.Forms.ProgressBar();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.prAddRandomWords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRandomWordtoDB
            // 
            this.btnAddRandomWordtoDB.Location = new System.Drawing.Point(12, 12);
            this.btnAddRandomWordtoDB.Name = "btnAddRandomWordtoDB";
            this.btnAddRandomWordtoDB.Size = new System.Drawing.Size(204, 29);
            this.btnAddRandomWordtoDB.TabIndex = 0;
            this.btnAddRandomWordtoDB.Text = "Add RandomWordsToDB";
            this.btnAddRandomWordtoDB.UseVisualStyleBackColor = true;
            this.btnAddRandomWordtoDB.Click += new System.EventHandler(this.btnAddRandomWordtoDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Count";
            // 
            // txtRandomWordToBeAddCount
            // 
            this.txtRandomWordToBeAddCount.Location = new System.Drawing.Point(289, 12);
            this.txtRandomWordToBeAddCount.Name = "txtRandomWordToBeAddCount";
            this.txtRandomWordToBeAddCount.Size = new System.Drawing.Size(125, 27);
            this.txtRandomWordToBeAddCount.TabIndex = 2;
            // 
            // prAddRandomWords
            // 
            this.prAddRandomWords.ContainerControl = this;
            // 
            // pBarAddingRandomWords
            // 
            this.pBarAddingRandomWords.Location = new System.Drawing.Point(437, 10);
            this.pBarAddingRandomWords.Name = "pBarAddingRandomWords";
            this.pBarAddingRandomWords.Size = new System.Drawing.Size(150, 29);
            this.pBarAddingRandomWords.TabIndex = 3;
            this.pBarAddingRandomWords.Visible = false;
            this.pBarAddingRandomWords.Click += new System.EventHandler(this.pBarAddingRandomWords_Click);
            // 
            // bgw
            // 
            this.bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            // 
            // AdminTransactionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBarAddingRandomWords);
            this.Controls.Add(this.txtRandomWordToBeAddCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRandomWordtoDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminTransactionsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminTransactionsPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminTransactionsPage_FormClosing);
            this.Load += new System.EventHandler(this.AdminTransactionsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prAddRandomWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRandomWordToBeAddCount;
        private System.Windows.Forms.ErrorProvider prAddRandomWords;
        private System.ComponentModel.BackgroundWorker bgw;
        internal System.Windows.Forms.ProgressBar pBarAddingRandomWords;
        internal System.Windows.Forms.Button btnAddRandomWordtoDB;
    }
}