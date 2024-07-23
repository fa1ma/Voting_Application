namespace VotingSystem
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.informationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationDataSet = new VotingSystem.InformationDataSet();
            this.btnAView = new System.Windows.Forms.Button();
            this.btnALogout = new System.Windows.Forms.Button();
            this.btnASaveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxAName = new System.Windows.Forms.TextBox();
            this.txtBxAAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxAPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxAMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxADelete = new System.Windows.Forms.TextBox();
            this.btnADelete = new System.Windows.Forms.Button();
            this.candidatesTableAdapter = new VotingSystem.InformationDataSetTableAdapters.CandidatesTableAdapter();
            this.txtBxANumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dGVCandidates = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCandidates)).BeginInit();
            this.SuspendLayout();
            // 
            // informationDataSetBindingSource
            // 
            this.informationDataSetBindingSource.DataSource = this.informationDataSet;
            this.informationDataSetBindingSource.Position = 0;
            // 
            // informationDataSet
            // 
            this.informationDataSet.DataSetName = "InformationDataSet";
            this.informationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAView
            // 
            this.btnAView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAView.Location = new System.Drawing.Point(22, 44);
            this.btnAView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAView.Name = "btnAView";
            this.btnAView.Size = new System.Drawing.Size(70, 24);
            this.btnAView.TabIndex = 1;
            this.btnAView.Text = "View";
            this.btnAView.UseVisualStyleBackColor = false;
            this.btnAView.Click += new System.EventHandler(this.btnAView_Click);
            // 
            // btnALogout
            // 
            this.btnALogout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnALogout.Location = new System.Drawing.Point(22, 392);
            this.btnALogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnALogout.Name = "btnALogout";
            this.btnALogout.Size = new System.Drawing.Size(70, 24);
            this.btnALogout.TabIndex = 2;
            this.btnALogout.Text = "Logout";
            this.btnALogout.UseVisualStyleBackColor = false;
            this.btnALogout.Click += new System.EventHandler(this.btnALogout_Click);
            // 
            // btnASaveChanges
            // 
            this.btnASaveChanges.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnASaveChanges.Location = new System.Drawing.Point(518, 322);
            this.btnASaveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnASaveChanges.Name = "btnASaveChanges";
            this.btnASaveChanges.Size = new System.Drawing.Size(82, 24);
            this.btnASaveChanges.TabIndex = 3;
            this.btnASaveChanges.Text = "Save Changes";
            this.btnASaveChanges.UseVisualStyleBackColor = false;
            this.btnASaveChanges.Click += new System.EventHandler(this.btnASaveChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // txtBxAName
            // 
            this.txtBxAName.Location = new System.Drawing.Point(686, 93);
            this.txtBxAName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxAName.Name = "txtBxAName";
            this.txtBxAName.Size = new System.Drawing.Size(172, 20);
            this.txtBxAName.TabIndex = 5;
            // 
            // txtBxAAge
            // 
            this.txtBxAAge.Location = new System.Drawing.Point(686, 124);
            this.txtBxAAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxAAge.Name = "txtBxAAge";
            this.txtBxAAge.Size = new System.Drawing.Size(172, 20);
            this.txtBxAAge.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age:";
            // 
            // txtBxAPassword
            // 
            this.txtBxAPassword.Location = new System.Drawing.Point(686, 185);
            this.txtBxAPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxAPassword.Name = "txtBxAPassword";
            this.txtBxAPassword.PasswordChar = '*';
            this.txtBxAPassword.Size = new System.Drawing.Size(172, 20);
            this.txtBxAPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // txtBxAMail
            // 
            this.txtBxAMail.Location = new System.Drawing.Point(686, 154);
            this.txtBxAMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxAMail.Name = "txtBxAMail";
            this.txtBxAMail.Size = new System.Drawing.Size(172, 20);
            this.txtBxAMail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail:";
            // 
            // btnAInsert
            // 
            this.btnAInsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAInsert.Location = new System.Drawing.Point(786, 253);
            this.btnAInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAInsert.Name = "btnAInsert";
            this.btnAInsert.Size = new System.Drawing.Size(70, 24);
            this.btnAInsert.TabIndex = 12;
            this.btnAInsert.Text = "Insert";
            this.btnAInsert.UseVisualStyleBackColor = false;
            this.btnAInsert.Click += new System.EventHandler(this.btnAInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(790, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = ":";
            // 
            // txtBxADelete
            // 
            this.txtBxADelete.Location = new System.Drawing.Point(734, 370);
            this.txtBxADelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxADelete.Name = "txtBxADelete";
            this.txtBxADelete.Size = new System.Drawing.Size(54, 20);
            this.txtBxADelete.TabIndex = 16;
            // 
            // btnADelete
            // 
            this.btnADelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnADelete.Location = new System.Drawing.Point(805, 368);
            this.btnADelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnADelete.Name = "btnADelete";
            this.btnADelete.Size = new System.Drawing.Size(70, 24);
            this.btnADelete.TabIndex = 17;
            this.btnADelete.Text = "Delete";
            this.btnADelete.UseVisualStyleBackColor = false;
            this.btnADelete.Click += new System.EventHandler(this.btnADelete_Click);
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // txtBxANumber
            // 
            this.txtBxANumber.Location = new System.Drawing.Point(686, 217);
            this.txtBxANumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBxANumber.Name = "txtBxANumber";
            this.txtBxANumber.Size = new System.Drawing.Size(172, 20);
            this.txtBxANumber.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 374);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID:";
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "Candidates";
            this.candidatesBindingSource.DataSource = this.informationDataSetBindingSource;
            // 
            // dGVCandidates
            // 
            this.dGVCandidates.AllowUserToAddRows = false;
            this.dGVCandidates.AllowUserToDeleteRows = false;
            this.dGVCandidates.AutoGenerateColumns = false;
            this.dGVCandidates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVCandidates.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dGVCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.Number});
            this.dGVCandidates.DataSource = this.candidatesBindingSource;
            this.dGVCandidates.Location = new System.Drawing.Point(22, 80);
            this.dGVCandidates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGVCandidates.Name = "dGVCandidates";
            this.dGVCandidates.RowHeadersWidth = 51;
            this.dGVCandidates.RowTemplate.Height = 24;
            this.dGVCandidates.Size = new System.Drawing.Size(572, 236);
            this.dGVCandidates.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChart.Location = new System.Drawing.Point(22, 322);
            this.btnChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(85, 24);
            this.btnChart.TabIndex = 22;
            this.btnChart.Text = "Show Chart";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(901, 426);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxANumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dGVCandidates);
            this.Controls.Add(this.btnADelete);
            this.Controls.Add(this.txtBxADelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAInsert);
            this.Controls.Add(this.txtBxAPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxAMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxAAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxAName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnASaveChanges);
            this.Controls.Add(this.btnALogout);
            this.Controls.Add(this.btnAView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCandidates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAView;
        private System.Windows.Forms.Button btnALogout;
        private System.Windows.Forms.Button btnASaveChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxAName;
        private System.Windows.Forms.TextBox txtBxAAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxAPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxAMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxADelete;
        private System.Windows.Forms.Button btnADelete;
        private System.Windows.Forms.BindingSource informationDataSetBindingSource;
        private InformationDataSet informationDataSet;
        private InformationDataSetTableAdapters.CandidatesTableAdapter candidatesTableAdapter;
        private System.Windows.Forms.TextBox txtBxANumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dGVCandidates;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.Button btnChart;
    }
}