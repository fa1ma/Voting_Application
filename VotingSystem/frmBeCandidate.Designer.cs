namespace VotingSystem
{
    partial class frmBeCandidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeCandidate));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxCName = new System.Windows.Forms.TextBox();
            this.txtBxCAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxCMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxCPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxCNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBCGetBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtBxCName
            // 
            this.txtBxCName.Location = new System.Drawing.Point(151, 99);
            this.txtBxCName.Name = "txtBxCName";
            this.txtBxCName.Size = new System.Drawing.Size(234, 22);
            this.txtBxCName.TabIndex = 1;
            // 
            // txtBxCAge
            // 
            this.txtBxCAge.Location = new System.Drawing.Point(151, 141);
            this.txtBxCAge.Name = "txtBxCAge";
            this.txtBxCAge.Size = new System.Drawing.Size(234, 22);
            this.txtBxCAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            // 
            // txtBxCMail
            // 
            this.txtBxCMail.Location = new System.Drawing.Point(151, 184);
            this.txtBxCMail.Name = "txtBxCMail";
            this.txtBxCMail.Size = new System.Drawing.Size(234, 22);
            this.txtBxCMail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail:";
            // 
            // txtBxCPassword
            // 
            this.txtBxCPassword.Location = new System.Drawing.Point(151, 227);
            this.txtBxCPassword.Name = "txtBxCPassword";
            this.txtBxCPassword.PasswordChar = '*';
            this.txtBxCPassword.Size = new System.Drawing.Size(234, 22);
            this.txtBxCPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // txtBxCNumber
            // 
            this.txtBxCNumber.Location = new System.Drawing.Point(151, 268);
            this.txtBxCNumber.Name = "txtBxCNumber";
            this.txtBxCNumber.Size = new System.Drawing.Size(234, 22);
            this.txtBxCNumber.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(65, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "Candidate";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegister.Location = new System.Drawing.Point(293, 313);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(92, 36);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBCGetBack
            // 
            this.btnBCGetBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBCGetBack.Location = new System.Drawing.Point(12, 351);
            this.btnBCGetBack.Name = "btnBCGetBack";
            this.btnBCGetBack.Size = new System.Drawing.Size(80, 29);
            this.btnBCGetBack.TabIndex = 24;
            this.btnBCGetBack.Text = "get back";
            this.btnBCGetBack.UseVisualStyleBackColor = false;
            this.btnBCGetBack.Click += new System.EventHandler(this.btnBCGetBack_Click);
            // 
            // frmBeCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(466, 392);
            this.Controls.Add(this.btnBCGetBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxCNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxCPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxCMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxCAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxCName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeCandidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxCName;
        private System.Windows.Forms.TextBox txtBxCAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxCMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxCPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxCNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBCGetBack;
    }
}