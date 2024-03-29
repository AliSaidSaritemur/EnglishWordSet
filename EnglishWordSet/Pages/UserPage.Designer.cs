﻿
namespace EnglishWordSet
{
    partial class UserPage
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
            this.pbAdminPageOpen = new System.Windows.Forms.PictureBox();
            this.pbOpenGamePanel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminPageOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenGamePanel)).BeginInit();
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
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::EnglishWordSet.Properties.Resources.back;
            this.pbBack.Location = new System.Drawing.Point(12, 431);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(98, 80);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 16;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbAdminPageOpen
            // 
            this.pbAdminPageOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbAdminPageOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdminPageOpen.Image = global::EnglishWordSet.Properties.Resources.adminIcon;
            this.pbAdminPageOpen.Location = new System.Drawing.Point(663, 404);
            this.pbAdminPageOpen.Name = "pbAdminPageOpen";
            this.pbAdminPageOpen.Size = new System.Drawing.Size(125, 107);
            this.pbAdminPageOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdminPageOpen.TabIndex = 18;
            this.pbAdminPageOpen.TabStop = false;
            this.pbAdminPageOpen.Visible = false;
            this.pbAdminPageOpen.Click += new System.EventHandler(this.pbAdminPageOpen_Click);
            // 
            // pbOpenGamePanel
            // 
            this.pbOpenGamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOpenGamePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOpenGamePanel.Image = global::EnglishWordSet.Properties.Resources.GameIcon;
            this.pbOpenGamePanel.Location = new System.Drawing.Point(22, 346);
            this.pbOpenGamePanel.Name = "pbOpenGamePanel";
            this.pbOpenGamePanel.Size = new System.Drawing.Size(73, 67);
            this.pbOpenGamePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpenGamePanel.TabIndex = 20;
            this.pbOpenGamePanel.TabStop = false;
            this.pbOpenGamePanel.Click += new System.EventHandler(this.pbOpenGamePanel_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.pbOpenGamePanel);
            this.Controls.Add(this.pbAdminPageOpen);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.btnAddLearnedWord);
            this.Controls.Add(this.btnAddNewWord);
            this.Controls.Add(this.btnAddNewAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_FormClosing);
            this.Load += new System.EventHandler(this.btnAddNewWord_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminPageOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenGamePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewWord;
        private System.Windows.Forms.Button btnAddNewAdmin;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Button btnAddLearnedWord;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbAdminPageOpen;
        private System.Windows.Forms.PictureBox pbOpenGamePanel;
    }
}