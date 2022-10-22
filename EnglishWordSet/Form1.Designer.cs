
namespace EnglishWordSet
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBSave = new System.Windows.Forms.CheckBox();
            this.btnGetSaveText = new System.Windows.Forms.Button();
            this.cbSpace = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(28, 200);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(329, 238);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(410, 200);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(329, 238);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(330, 81);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 29);
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
            this.btnGetSaveText.Location = new System.Drawing.Point(522, 165);
            this.btnGetSaveText.Name = "btnGetSaveText";
            this.btnGetSaveText.Size = new System.Drawing.Size(94, 29);
            this.btnGetSaveText.TabIndex = 6;
            this.btnGetSaveText.Text = "SaveTexts";
            this.btnGetSaveText.UseVisualStyleBackColor = true;
            this.btnGetSaveText.Click += new System.EventHandler(this.btnGetSaveText_Click);
            // 
            // cbSpace
            // 
            this.cbSpace.AutoSize = true;
            this.cbSpace.Checked = true;
            this.cbSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpace.Location = new System.Drawing.Point(61, 72);
            this.cbSpace.Name = "cbSpace";
            this.cbSpace.Size = new System.Drawing.Size(195, 24);
            this.cbSpace.TabIndex = 7;
            this.cbSpace.Text = "Sapce between each line";
            this.cbSpace.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSpace);
            this.Controls.Add(this.btnGetSaveText);
            this.Controls.Add(this.cBSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.CheckBox cbSpace;
    }
}

