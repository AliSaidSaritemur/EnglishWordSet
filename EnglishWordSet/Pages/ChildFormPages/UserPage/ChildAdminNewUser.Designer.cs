namespace EnglishWordSet.ChildForms.AdminPage
{
    partial class ChildAdminNewUser
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
            this.phoneProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UserNameProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgainPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmitNewAdmin = new System.Windows.Forms.Button();
            this.againPasswordProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.phoneProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.againPasswordProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneProvider
            // 
            this.phoneProvider.ContainerControl = this;
            // 
            // emailProvider
            // 
            this.emailProvider.ContainerControl = this;
            // 
            // UserNameProvider
            // 
            this.UserNameProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(193, 77);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(125, 27);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 138);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 27);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(189, 191);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(125, 27);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(41, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "New Admin Properties";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(189, 234);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(125, 27);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // txtAgainPassword
            // 
            this.txtAgainPassword.Location = new System.Drawing.Point(189, 282);
            this.txtAgainPassword.Name = "txtAgainPassword";
            this.txtAgainPassword.PasswordChar = '*';
            this.txtAgainPassword.Size = new System.Drawing.Size(125, 27);
            this.txtAgainPassword.TabIndex = 13;
            this.txtAgainPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAgainPassword_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Again Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSubmitNewAdmin
            // 
            this.btnSubmitNewAdmin.Location = new System.Drawing.Point(99, 330);
            this.btnSubmitNewAdmin.Name = "btnSubmitNewAdmin";
            this.btnSubmitNewAdmin.Size = new System.Drawing.Size(114, 39);
            this.btnSubmitNewAdmin.TabIndex = 14;
            this.btnSubmitNewAdmin.Text = "Submit";
            this.btnSubmitNewAdmin.UseVisualStyleBackColor = true;
            this.btnSubmitNewAdmin.Click += new System.EventHandler(this.btnSubmitNewAdmin_Click);
            // 
            // againPasswordProvider
            // 
            this.againPasswordProvider.ContainerControl = this;
            // 
            // passwordProvider
            // 
            this.passwordProvider.ContainerControl = this;
            // 
            // ChildAdminNewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(357, 381);
            this.Controls.Add(this.btnSubmitNewAdmin);
            this.Controls.Add(this.txtAgainPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChildAdminNewAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChildAdminNewAdmin";
            this.Load += new System.EventHandler(this.ChildAdminNewAdmin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChildAdminNewAdmin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.phoneProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.againPasswordProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgainPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmitNewAdmin;
        private System.Windows.Forms.ErrorProvider emailProvider;
        private System.Windows.Forms.ErrorProvider UserNameProvider;
        private System.Windows.Forms.ErrorProvider phoneProvider;
        private System.Windows.Forms.ErrorProvider againPasswordProvider;
        private System.Windows.Forms.ErrorProvider passwordProvider;
    }
}