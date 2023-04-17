namespace EnglishWordSet.Pages
{
    partial class LearnedWordsPanel
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Sentence = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.lblSentence = new System.Windows.Forms.Label();
            this.lblSentences = new System.Windows.Forms.Label();
            this.pBLearned = new System.Windows.Forms.PictureBox();
            this.epWifiConnectionImage = new System.Windows.Forms.ErrorProvider(this.components);
            this.WifiEPtimer = new System.Windows.Forms.Timer(this.components);
            this.timerImageEnable = new System.Windows.Forms.Timer(this.components);
            this.btnChangeImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLearned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWifiConnectionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(206, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // Sentence
            // 
            this.Sentence.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sentence.Location = new System.Drawing.Point(12, 113);
            this.Sentence.Name = "Sentence";
            this.Sentence.Size = new System.Drawing.Size(99, 38);
            this.Sentence.TabIndex = 1;
            this.Sentence.Text = "Sentence : ";
            this.Sentence.UseCompatibleTextRendering = true;
            // 
            // pbSearch
            // 
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = global::EnglishWordSet.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(385, 53);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(38, 33);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 2;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // lblSentence
            // 
            this.lblSentence.AutoSize = true;
            this.lblSentence.Location = new System.Drawing.Point(137, 115);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Size = new System.Drawing.Size(0, 20);
            this.lblSentence.TabIndex = 3;
            // 
            // lblSentences
            // 
            this.lblSentences.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSentences.Location = new System.Drawing.Point(103, 113);
            this.lblSentences.Name = "lblSentences";
            this.lblSentences.Size = new System.Drawing.Size(502, 68);
            this.lblSentences.TabIndex = 4;
            // 
            // pBLearned
            // 
            this.pBLearned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBLearned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBLearned.Enabled = false;
            this.pBLearned.Image = global::EnglishWordSet.Properties.Resources.tipMark;
            this.pBLearned.Location = new System.Drawing.Point(179, 184);
            this.pBLearned.Name = "pBLearned";
            this.pBLearned.Size = new System.Drawing.Size(244, 140);
            this.pBLearned.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBLearned.TabIndex = 5;
            this.pBLearned.TabStop = false;
            this.pBLearned.Visible = false;
            this.pBLearned.Click += new System.EventHandler(this.pBLearned_Click);
            // 
            // epWifiConnectionImage
            // 
            this.epWifiConnectionImage.ContainerControl = this;
            // 
            // WifiEPtimer
            // 
            this.WifiEPtimer.Interval = 400;
            this.WifiEPtimer.Tick += new System.EventHandler(this.WifiEPtimer_Tick);
            // 
            // timerImageEnable
            // 
            this.timerImageEnable.Interval = 1000;
            this.timerImageEnable.Tick += new System.EventHandler(this.timerImageEnable_Tick);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(254, 330);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(94, 29);
            this.btnChangeImage.TabIndex = 6;
            this.btnChangeImage.Text = "Change";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Visible = false;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_ClickAsync);
            // 
            // LearnedWordsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 367);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.pBLearned);
            this.Controls.Add(this.lblSentences);
            this.Controls.Add(this.lblSentence);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.Sentence);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LearnedWordsPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LearnedWordsPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LearnedWordsPanel_FormClosing);
            this.Load += new System.EventHandler(this.LearnedWordsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLearned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWifiConnectionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Label lblSentence;
        private System.Windows.Forms.Label Sentence;
        private System.Windows.Forms.Label lblSentences;
        private System.Windows.Forms.PictureBox pBLearned;
        private System.Windows.Forms.ErrorProvider epWifiConnectionImage;
        private System.Windows.Forms.Timer WifiEPtimer;
        private System.Windows.Forms.Timer timerImageEnable;
        private System.Windows.Forms.Button btnChangeImage;
    }
}