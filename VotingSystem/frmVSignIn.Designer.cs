namespace VotingSystem
{
    partial class frmVSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVSignIn));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxVSName = new System.Windows.Forms.TextBox();
            this.txtBxVSAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxVSMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxVSPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnVSGetBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtBxVSName
            // 
            this.txtBxVSName.Location = new System.Drawing.Point(137, 111);
            this.txtBxVSName.Name = "txtBxVSName";
            this.txtBxVSName.Size = new System.Drawing.Size(246, 22);
            this.txtBxVSName.TabIndex = 1;
            // 
            // txtBxVSAge
            // 
            this.txtBxVSAge.Location = new System.Drawing.Point(137, 154);
            this.txtBxVSAge.Name = "txtBxVSAge";
            this.txtBxVSAge.Size = new System.Drawing.Size(246, 22);
            this.txtBxVSAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            // 
            // txtBxVSMail
            // 
            this.txtBxVSMail.Location = new System.Drawing.Point(137, 198);
            this.txtBxVSMail.Name = "txtBxVSMail";
            this.txtBxVSMail.Size = new System.Drawing.Size(246, 22);
            this.txtBxVSMail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail:";
            // 
            // txtBxVSPassword
            // 
            this.txtBxVSPassword.Location = new System.Drawing.Point(137, 242);
            this.txtBxVSPassword.Name = "txtBxVSPassword";
            this.txtBxVSPassword.PasswordChar = '*';
            this.txtBxVSPassword.Size = new System.Drawing.Size(246, 22);
            this.txtBxVSPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(58, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "Voter";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegister.Location = new System.Drawing.Point(291, 297);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(92, 36);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnVSGetBack
            // 
            this.btnVSGetBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVSGetBack.Location = new System.Drawing.Point(12, 341);
            this.btnVSGetBack.Name = "btnVSGetBack";
            this.btnVSGetBack.Size = new System.Drawing.Size(80, 29);
            this.btnVSGetBack.TabIndex = 24;
            this.btnVSGetBack.Text = "get back";
            this.btnVSGetBack.UseVisualStyleBackColor = false;
            this.btnVSGetBack.Click += new System.EventHandler(this.btnVSGetBack_Click);
            // 
            // frmVSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(451, 382);
            this.Controls.Add(this.btnVSGetBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxVSPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxVSMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxVSAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxVSName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxVSName;
        private System.Windows.Forms.TextBox txtBxVSAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxVSMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxVSPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnVSGetBack;
    }
}