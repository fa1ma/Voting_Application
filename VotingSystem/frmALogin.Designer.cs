namespace VotingSystem
{
    partial class frmALogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmALogin));
            this.btnALGetBack = new System.Windows.Forms.Button();
            this.btnALogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxALPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxALMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnALGetBack
            // 
            this.btnALGetBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnALGetBack.Location = new System.Drawing.Point(12, 244);
            this.btnALGetBack.Name = "btnALGetBack";
            this.btnALGetBack.Size = new System.Drawing.Size(80, 29);
            this.btnALGetBack.TabIndex = 30;
            this.btnALGetBack.Text = "get back";
            this.btnALGetBack.UseVisualStyleBackColor = false;
            this.btnALGetBack.Click += new System.EventHandler(this.btnALGetBack_Click);
            // 
            // btnALogin
            // 
            this.btnALogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnALogin.Location = new System.Drawing.Point(338, 209);
            this.btnALogin.Name = "btnALogin";
            this.btnALogin.Size = new System.Drawing.Size(92, 36);
            this.btnALogin.TabIndex = 29;
            this.btnALogin.Text = "Login";
            this.btnALogin.UseVisualStyleBackColor = false;
            this.btnALogin.Click += new System.EventHandler(this.btnALogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(105, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 35);
            this.label6.TabIndex = 28;
            this.label6.Text = "Admin";
            // 
            // txtBxALPassword
            // 
            this.txtBxALPassword.Location = new System.Drawing.Point(184, 153);
            this.txtBxALPassword.Name = "txtBxALPassword";
            this.txtBxALPassword.PasswordChar = '*';
            this.txtBxALPassword.Size = new System.Drawing.Size(246, 22);
            this.txtBxALPassword.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password:";
            // 
            // txtBxALMail
            // 
            this.txtBxALMail.Location = new System.Drawing.Point(184, 109);
            this.txtBxALMail.Name = "txtBxALMail";
            this.txtBxALMail.Size = new System.Drawing.Size(246, 22);
            this.txtBxALMail.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mail:";
            // 
            // frmALogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(541, 285);
            this.Controls.Add(this.btnALGetBack);
            this.Controls.Add(this.btnALogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxALPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxALMail);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmALogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnALGetBack;
        private System.Windows.Forms.Button btnALogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxALPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxALMail;
        private System.Windows.Forms.Label label3;
    }
}