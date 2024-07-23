namespace VotingSystem
{
    partial class frmVLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVLogin));
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxVLPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxVLMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVLGetBack = new System.Windows.Forms.Button();
            this.btnVLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(77, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 27);
            this.label6.TabIndex = 21;
            this.label6.Text = "Voter";
            // 
            // txtBxVLPassword
            // 
            this.txtBxVLPassword.Location = new System.Drawing.Point(136, 137);
            this.txtBxVLPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxVLPassword.Name = "txtBxVLPassword";
            this.txtBxVLPassword.PasswordChar = '*';
            this.txtBxVLPassword.Size = new System.Drawing.Size(186, 20);
            this.txtBxVLPassword.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password:";
            // 
            // txtBxVLMail
            // 
            this.txtBxVLMail.Location = new System.Drawing.Point(136, 102);
            this.txtBxVLMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxVLMail.Name = "txtBxVLMail";
            this.txtBxVLMail.Size = new System.Drawing.Size(186, 20);
            this.txtBxVLMail.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mail:";
            // 
            // btnVLGetBack
            // 
            this.btnVLGetBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVLGetBack.Location = new System.Drawing.Point(9, 215);
            this.btnVLGetBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVLGetBack.Name = "btnVLGetBack";
            this.btnVLGetBack.Size = new System.Drawing.Size(61, 23);
            this.btnVLGetBack.TabIndex = 22;
            this.btnVLGetBack.Text = "get back";
            this.btnVLGetBack.UseVisualStyleBackColor = false;
            this.btnVLGetBack.Click += new System.EventHandler(this.btnVLGetBack_Click_1);
            // 
            // btnVLogin
            // 
            this.btnVLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVLogin.Location = new System.Drawing.Point(260, 176);
            this.btnVLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVLogin.Name = "btnVLogin";
            this.btnVLogin.Size = new System.Drawing.Size(62, 24);
            this.btnVLogin.TabIndex = 23;
            this.btnVLogin.Text = "Login";
            this.btnVLogin.UseVisualStyleBackColor = false;
            this.btnVLogin.Click += new System.EventHandler(this.btnVLogin_Click_1);
            // 
            // frmVLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(406, 248);
            this.Controls.Add(this.btnVLogin);
            this.Controls.Add(this.btnVLGetBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxVLPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxVLMail);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxVLPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxVLMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVLGetBack;
        private System.Windows.Forms.Button btnVLogin;
    }
}