
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
            this.btnAddNewAdmin = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.btnAddLearnedWord = new System.Windows.Forms.Button();
            this.pbBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewWord
            // 
            this.btnAddNewWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewWord.Location = new System.Drawing.Point(532, -1);
            this.btnAddNewWord.Name = "btnAddNewWord";
            this.btnAddNewWord.Size = new System.Drawing.Size(269, 89);
            this.btnAddNewWord.TabIndex = 11;
            this.btnAddNewWord.Text = "Add New Words";
            this.btnAddNewWord.UseVisualStyleBackColor = true;
            this.btnAddNewWord.Click += new System.EventHandler(this.btnAddNewWord_Click);
            this.btnAddNewWord.Enter += new System.EventHandler(this.btnAddNewWord_Enter);
            this.btnAddNewWord.Leave += new System.EventHandler(this.btnAddNewWord_Leave);
            // 
            // btnAddNewAdmin
            // 
            this.btnAddNewAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewAdmin.Location = new System.Drawing.Point(-1, -1);
            this.btnAddNewAdmin.Name = "btnAddNewAdmin";
            this.btnAddNewAdmin.Size = new System.Drawing.Size(267, 89);
            this.btnAddNewAdmin.TabIndex = 12;
            this.btnAddNewAdmin.Text = "Add New Admin";
            this.btnAddNewAdmin.UseVisualStyleBackColor = true;
            this.btnAddNewAdmin.Click += new System.EventHandler(this.button1_Click);
            this.btnAddNewAdmin.Enter += new System.EventHandler(this.btnAddNewAdmin_Enter);
            this.btnAddNewAdmin.Leave += new System.EventHandler(this.btnAddNewAdmin_Leave);
            // 
            // btnAddLearnedWord
            // 
            this.btnAddLearnedWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddLearnedWord.Location = new System.Drawing.Point(261, -1);
            this.btnAddLearnedWord.Name = "btnAddLearnedWord";
            this.btnAddLearnedWord.Size = new System.Drawing.Size(276, 89);
            this.btnAddLearnedWord.TabIndex = 14;
            this.btnAddLearnedWord.Text = "Add Learned Word";
            this.btnAddLearnedWord.UseVisualStyleBackColor = true;
            this.btnAddLearnedWord.Click += new System.EventHandler(this.btnAddLearnedWord_Click);
            this.btnAddLearnedWord.Enter += new System.EventHandler(this.btnAddLearnedWord_Enter);
            this.btnAddLearnedWord.Leave += new System.EventHandler(this.btnAddLearnedWord_Leave);
            // 
            // pbBack
            // 
            this.pbBack.Image = global::EnglishWordSet.Properties.Resources.back;
            this.pbBack.Location = new System.Drawing.Point(12, 431);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(98, 80);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 16;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.btnAddLearnedWord);
            this.Controls.Add(this.btnAddNewWord);
            this.Controls.Add(this.btnAddNewAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5";
            this.Activated += new System.EventHandler(this.AdminPage_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewWord;
        private System.Windows.Forms.Button btnAddNewAdmin;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Button btnAddLearnedWord;
        private System.Windows.Forms.PictureBox pbBack;
    }
}