namespace EnglishWordSet.Pages
{
    partial class UserPasswordResetPage
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordAgain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnResetUsetPassword = new System.Windows.Forms.Button();
            this.cbMailVerificationCode = new System.Windows.Forms.CheckBox();
            this.prUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.prPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(209, 64);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(125, 27);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password Again";
            // 
            // txtPasswordAgain
            // 
            this.txtPasswordAgain.Location = new System.Drawing.Point(209, 169);
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.PasswordChar = '*';
            this.txtPasswordAgain.Size = new System.Drawing.Size(125, 27);
            this.txtPasswordAgain.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(209, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(125, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // btnResetUsetPassword
            // 
            this.btnResetUsetPassword.Location = new System.Drawing.Point(128, 295);
            this.btnResetUsetPassword.Name = "btnResetUsetPassword";
            this.btnResetUsetPassword.Size = new System.Drawing.Size(94, 29);
            this.btnResetUsetPassword.TabIndex = 6;
            this.btnResetUsetPassword.Text = "Submit";
            this.btnResetUsetPassword.UseVisualStyleBackColor = true;
            this.btnResetUsetPassword.Click += new System.EventHandler(this.btnResetUsetPassword_Click);
            // 
            // cbMailVerificationCode
            // 
            this.cbMailVerificationCode.AutoSize = true;
            this.cbMailVerificationCode.Enabled = false;
            this.cbMailVerificationCode.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbMailVerificationCode.Location = new System.Drawing.Point(255, 299);
            this.cbMailVerificationCode.Name = "cbMailVerificationCode";
            this.cbMailVerificationCode.Size = new System.Drawing.Size(111, 22);
            this.cbMailVerificationCode.TabIndex = 7;
            this.cbMailVerificationCode.Text = "Mail Check";
            this.cbMailVerificationCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbMailVerificationCode.UseVisualStyleBackColor = true;
            this.cbMailVerificationCode.Click += new System.EventHandler(this.cbMailVerificationCode_Click);
            // 
            // prUserName
            // 
            this.prUserName.ContainerControl = this;
            // 
            // prPassword
            // 
            this.prPassword.ContainerControl = this;
            // 
            // UserPasswordResetPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 336);
            this.Controls.Add(this.cbMailVerificationCode);
            this.Controls.Add(this.btnResetUsetPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPasswordAgain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.MaximizeBox = false;
            this.Name = "UserPasswordResetPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPasswordResetPage";
            this.Load += new System.EventHandler(this.UserPasswordResetPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordAgain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnResetUsetPassword;
        private System.Windows.Forms.CheckBox cbMailVerificationCode;
        private System.Windows.Forms.ErrorProvider prUserName;
        private System.Windows.Forms.ErrorProvider prPassword;
    }
}