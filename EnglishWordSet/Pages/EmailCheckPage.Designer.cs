namespace EnglishWordSet.Pages
{
    partial class EmailCheckPage
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
            this.tmrCode = new System.Windows.Forms.Timer(this.components);
            this.lblTimeToEnterCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVerificationCode = new System.Windows.Forms.TextBox();
            this.btnCheckCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrCode
            // 
            this.tmrCode.Interval = 1000;
            this.tmrCode.Tick += new System.EventHandler(this.tmrCode_Tick);
            // 
            // lblTimeToEnterCode
            // 
            this.lblTimeToEnterCode.AutoSize = true;
            this.lblTimeToEnterCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimeToEnterCode.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeToEnterCode.Location = new System.Drawing.Point(524, 22);
            this.lblTimeToEnterCode.Name = "lblTimeToEnterCode";
            this.lblTimeToEnterCode.Size = new System.Drawing.Size(43, 31);
            this.lblTimeToEnterCode.TabIndex = 0;
            this.lblTimeToEnterCode.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Your Verification Code";
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.Location = new System.Drawing.Point(223, 151);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(125, 27);
            this.txtVerificationCode.TabIndex = 2;
            this.txtVerificationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVerificationCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVerificationCode_KeyPress);
            // 
            // btnCheckCode
            // 
            this.btnCheckCode.Location = new System.Drawing.Point(236, 201);
            this.btnCheckCode.Name = "btnCheckCode";
            this.btnCheckCode.Size = new System.Drawing.Size(94, 29);
            this.btnCheckCode.TabIndex = 3;
            this.btnCheckCode.Text = "Submit";
            this.btnCheckCode.UseVisualStyleBackColor = true;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
            // 
            // EmailCheckPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 336);
            this.Controls.Add(this.btnCheckCode);
            this.Controls.Add(this.txtVerificationCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeToEnterCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmailCheckPage";
            this.Text = "EmailCheckPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrCode;
        private System.Windows.Forms.Label lblTimeToEnterCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVerificationCode;
        private System.Windows.Forms.Button btnCheckCode;
    }
}