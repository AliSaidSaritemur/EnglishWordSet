﻿
namespace EnglishWordSet
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBSave = new System.Windows.Forms.CheckBox();
            this.btnGetSaveText = new System.Windows.Forms.Button();
            this.btnGetNewWord = new System.Windows.Forms.Button();
            this.btnToAdminPage = new System.Windows.Forms.Button();
            this.getLaarnedWordPage = new System.Windows.Forms.Button();
            this.pbCopy = new System.Windows.Forms.PictureBox();
            this.timerCopySuccess = new System.Windows.Forms.Timer(this.components);
            this.pbPaste = new System.Windows.Forms.PictureBox();
            this.lblWordCountInput = new System.Windows.Forms.Label();
            this.lblWordDayAvarageInput = new System.Windows.Forms.Label();
            this.lblWordDayAvarageOutput = new System.Windows.Forms.Label();
            this.lblWordCountOutput = new System.Windows.Forms.Label();
            this.btnGetLast = new System.Windows.Forms.Button();
            this.cbSetDay = new System.Windows.Forms.CheckBox();
            this.btnOpenTurkishWordPage = new System.Windows.Forms.Button();
            this.btnOutputClean = new System.Windows.Forms.Button();
            this.btnInputClean = new System.Windows.Forms.Button();
            this.pbLogOutMainPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOutMainPage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput.Location = new System.Drawing.Point(28, 200);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(397, 286);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(547, 200);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(406, 286);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(454, 112);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(93, 31);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // cBSave
            // 
            this.cBSave.AutoSize = true;
            this.cBSave.Checked = true;
            this.cBSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBSave.Location = new System.Drawing.Point(61, 42);
            this.cBSave.Name = "cBSave";
            this.cBSave.Size = new System.Drawing.Size(60, 24);
            this.cBSave.TabIndex = 5;
            this.cBSave.Text = "save";
            this.cBSave.UseVisualStyleBackColor = true;
            // 
            // btnGetSaveText
            // 
            this.btnGetSaveText.Location = new System.Drawing.Point(719, 165);
            this.btnGetSaveText.Name = "btnGetSaveText";
            this.btnGetSaveText.Size = new System.Drawing.Size(94, 29);
            this.btnGetSaveText.TabIndex = 6;
            this.btnGetSaveText.Text = "SaveTexts";
            this.btnGetSaveText.UseVisualStyleBackColor = true;
            this.btnGetSaveText.Click += new System.EventHandler(this.btnGetSaveText_Click);
            // 
            // btnGetNewWord
            // 
            this.btnGetNewWord.Location = new System.Drawing.Point(887, 95);
            this.btnGetNewWord.Name = "btnGetNewWord";
            this.btnGetNewWord.Size = new System.Drawing.Size(136, 29);
            this.btnGetNewWord.TabIndex = 10;
            this.btnGetNewWord.Text = "Get New Word";
            this.btnGetNewWord.UseVisualStyleBackColor = true;
            this.btnGetNewWord.Click += new System.EventHandler(this.btnGetNewWord_Click);
            // 
            // btnToAdminPage
            // 
            this.btnToAdminPage.Location = new System.Drawing.Point(887, 51);
            this.btnToAdminPage.Name = "btnToAdminPage";
            this.btnToAdminPage.Size = new System.Drawing.Size(136, 29);
            this.btnToAdminPage.TabIndex = 11;
            this.btnToAdminPage.Text = "User Page";
            this.btnToAdminPage.UseVisualStyleBackColor = true;
            this.btnToAdminPage.Click += new System.EventHandler(this.btnToAdminPage_Click);
            // 
            // getLaarnedWordPage
            // 
            this.getLaarnedWordPage.Location = new System.Drawing.Point(423, 12);
            this.getLaarnedWordPage.Name = "getLaarnedWordPage";
            this.getLaarnedWordPage.Size = new System.Drawing.Size(160, 29);
            this.getLaarnedWordPage.TabIndex = 12;
            this.getLaarnedWordPage.Text = "Get Word Sentence";
            this.getLaarnedWordPage.UseVisualStyleBackColor = true;
            this.getLaarnedWordPage.Click += new System.EventHandler(this.getLaarnedWordPage_Click);
            // 
            // pbCopy
            // 
            this.pbCopy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCopy.Image = global::EnglishWordSet.Properties.Resources.Copy;
            this.pbCopy.Location = new System.Drawing.Point(874, 390);
            this.pbCopy.Name = "pbCopy";
            this.pbCopy.Size = new System.Drawing.Size(79, 96);
            this.pbCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCopy.TabIndex = 13;
            this.pbCopy.TabStop = false;
            this.pbCopy.Click += new System.EventHandler(this.pbCopy_Click);
            // 
            // timerCopySuccess
            // 
            this.timerCopySuccess.Interval = 1500;
            this.timerCopySuccess.Tick += new System.EventHandler(this.timerCopySuccess_Tick);
            // 
            // pbPaste
            // 
            this.pbPaste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPaste.Image = global::EnglishWordSet.Properties.Resources.paste;
            this.pbPaste.Location = new System.Drawing.Point(338, 390);
            this.pbPaste.Name = "pbPaste";
            this.pbPaste.Size = new System.Drawing.Size(87, 96);
            this.pbPaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPaste.TabIndex = 14;
            this.pbPaste.TabStop = false;
            this.pbPaste.Click += new System.EventHandler(this.pbPaste_Click);
            // 
            // lblWordCountInput
            // 
            this.lblWordCountInput.AutoSize = true;
            this.lblWordCountInput.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblWordCountInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWordCountInput.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWordCountInput.Location = new System.Drawing.Point(28, 507);
            this.lblWordCountInput.Name = "lblWordCountInput";
            this.lblWordCountInput.Size = new System.Drawing.Size(197, 22);
            this.lblWordCountInput.TabIndex = 15;
            this.lblWordCountInput.Text = "Word Count :          ";
            // 
            // lblWordDayAvarageInput
            // 
            this.lblWordDayAvarageInput.AutoSize = true;
            this.lblWordDayAvarageInput.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblWordDayAvarageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWordDayAvarageInput.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWordDayAvarageInput.Location = new System.Drawing.Point(231, 507);
            this.lblWordDayAvarageInput.Name = "lblWordDayAvarageInput";
            this.lblWordDayAvarageInput.Size = new System.Drawing.Size(203, 22);
            this.lblWordDayAvarageInput.TabIndex = 16;
            this.lblWordDayAvarageInput.Text = "Day Avarage :          ";
            // 
            // lblWordDayAvarageOutput
            // 
            this.lblWordDayAvarageOutput.AutoSize = true;
            this.lblWordDayAvarageOutput.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblWordDayAvarageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWordDayAvarageOutput.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWordDayAvarageOutput.Location = new System.Drawing.Point(763, 507);
            this.lblWordDayAvarageOutput.Name = "lblWordDayAvarageOutput";
            this.lblWordDayAvarageOutput.Size = new System.Drawing.Size(203, 22);
            this.lblWordDayAvarageOutput.TabIndex = 18;
            this.lblWordDayAvarageOutput.Text = "Day Avarage :          ";
            // 
            // lblWordCountOutput
            // 
            this.lblWordCountOutput.AutoSize = true;
            this.lblWordCountOutput.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblWordCountOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWordCountOutput.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWordCountOutput.Location = new System.Drawing.Point(560, 507);
            this.lblWordCountOutput.Name = "lblWordCountOutput";
            this.lblWordCountOutput.Size = new System.Drawing.Size(197, 22);
            this.lblWordCountOutput.TabIndex = 17;
            this.lblWordCountOutput.Text = "Word Count :          ";
            // 
            // btnGetLast
            // 
            this.btnGetLast.Location = new System.Drawing.Point(157, 165);
            this.btnGetLast.Name = "btnGetLast";
            this.btnGetLast.Size = new System.Drawing.Size(140, 29);
            this.btnGetLast.TabIndex = 19;
            this.btnGetLast.Text = "Get Last Words";
            this.btnGetLast.UseVisualStyleBackColor = true;
            this.btnGetLast.Click += new System.EventHandler(this.btnGetLast_Click);
            // 
            // cbSetDay
            // 
            this.cbSetDay.AutoSize = true;
            this.cbSetDay.Checked = true;
            this.cbSetDay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSetDay.Location = new System.Drawing.Point(61, 72);
            this.cbSetDay.Name = "cbSetDay";
            this.cbSetDay.Size = new System.Drawing.Size(88, 24);
            this.cbSetDay.TabIndex = 20;
            this.cbSetDay.Text = "Set Days";
            this.cbSetDay.UseVisualStyleBackColor = true;
            // 
            // btnOpenTurkishWordPage
            // 
            this.btnOpenTurkishWordPage.Location = new System.Drawing.Point(887, 12);
            this.btnOpenTurkishWordPage.Name = "btnOpenTurkishWordPage";
            this.btnOpenTurkishWordPage.Size = new System.Drawing.Size(136, 29);
            this.btnOpenTurkishWordPage.TabIndex = 21;
            this.btnOpenTurkishWordPage.Text = "TurkishWordPage";
            this.btnOpenTurkishWordPage.UseVisualStyleBackColor = true;
            this.btnOpenTurkishWordPage.Click += new System.EventHandler(this.btnOpenTurkishWordPage_Click);
            // 
            // btnOutputClean
            // 
            this.btnOutputClean.Location = new System.Drawing.Point(894, 200);
            this.btnOutputClean.Name = "btnOutputClean";
            this.btnOutputClean.Size = new System.Drawing.Size(59, 29);
            this.btnOutputClean.TabIndex = 22;
            this.btnOutputClean.Text = "Clean";
            this.btnOutputClean.UseVisualStyleBackColor = true;
            this.btnOutputClean.Click += new System.EventHandler(this.btnOutputClean_Click);
            // 
            // btnInputClean
            // 
            this.btnInputClean.Location = new System.Drawing.Point(366, 200);
            this.btnInputClean.Name = "btnInputClean";
            this.btnInputClean.Size = new System.Drawing.Size(59, 29);
            this.btnInputClean.TabIndex = 23;
            this.btnInputClean.Text = "Clean";
            this.btnInputClean.UseVisualStyleBackColor = true;
            this.btnInputClean.Click += new System.EventHandler(this.btnInputClean_Click);
            // 
            // pbLogOutMainPage
            // 
            this.pbLogOutMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogOutMainPage.Image = global::EnglishWordSet.Properties.Resources.logOutIcon;
            this.pbLogOutMainPage.Location = new System.Drawing.Point(9, 12);
            this.pbLogOutMainPage.Name = "pbLogOutMainPage";
            this.pbLogOutMainPage.Size = new System.Drawing.Size(46, 44);
            this.pbLogOutMainPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogOutMainPage.TabIndex = 24;
            this.pbLogOutMainPage.TabStop = false;
            this.pbLogOutMainPage.Click += new System.EventHandler(this.pbLogOutMainPage_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1026, 554);
            this.Controls.Add(this.pbLogOutMainPage);
            this.Controls.Add(this.btnInputClean);
            this.Controls.Add(this.btnOutputClean);
            this.Controls.Add(this.btnOpenTurkishWordPage);
            this.Controls.Add(this.cbSetDay);
            this.Controls.Add(this.btnGetLast);
            this.Controls.Add(this.lblWordDayAvarageOutput);
            this.Controls.Add(this.lblWordCountOutput);
            this.Controls.Add(this.lblWordDayAvarageInput);
            this.Controls.Add(this.lblWordCountInput);
            this.Controls.Add(this.pbPaste);
            this.Controls.Add(this.pbCopy);
            this.Controls.Add(this.getLaarnedWordPage);
            this.Controls.Add(this.btnToAdminPage);
            this.Controls.Add(this.btnGetNewWord);
            this.Controls.Add(this.btnGetSaveText);
            this.Controls.Add(this.cBSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOutMainPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBSave;
        private System.Windows.Forms.Button btnGetSaveText;
        private System.Windows.Forms.Button btnGetNewWord;
        private System.Windows.Forms.Button btnToAdminPage;
        private System.Windows.Forms.Button getLaarnedWordPage;
        private System.Windows.Forms.PictureBox pbCopy;
        private System.Windows.Forms.Timer timerCopySuccess;
        private System.Windows.Forms.Label lblWordCountInput;
        private System.Windows.Forms.Label lblWordDayAvarageInput;
        private System.Windows.Forms.Label lblWordDayAvarageOutput;
        private System.Windows.Forms.Label lblWordCountOutput;
        private System.Windows.Forms.Button btnGetLast;
        private System.Windows.Forms.CheckBox cbSetDay;
        internal System.Windows.Forms.PictureBox pbPaste;
        private System.Windows.Forms.Button btnOpenTurkishWordPage;
        private System.Windows.Forms.Button btnOutputClean;
        private System.Windows.Forms.Button btnInputClean;
        private System.Windows.Forms.PictureBox pbLogOutMainPage;
    }
}

