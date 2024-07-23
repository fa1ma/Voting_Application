namespace VotingSystem
{
    partial class frmVote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVote));
            this.informationDataSet = new VotingSystem.InformationDataSet();
            this.informationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidatesTableAdapter = new VotingSystem.InformationDataSetTableAdapters.CandidatesTableAdapter();
            this.btnVote = new System.Windows.Forms.Button();
            this.lstBxCandidates = new System.Windows.Forms.ListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.dGVVote = new System.Windows.Forms.DataGridView();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // informationDataSet
            // 
            this.informationDataSet.DataSetName = "InformationDataSet";
            this.informationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationDataSetBindingSource
            // 
            this.informationDataSetBindingSource.DataSource = this.informationDataSet;
            this.informationDataSetBindingSource.Position = 0;
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(689, 330);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(99, 31);
            this.btnVote.TabIndex = 2;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // lstBxCandidates
            // 
            this.lstBxCandidates.FormattingEnabled = true;
            this.lstBxCandidates.ItemHeight = 16;
            this.lstBxCandidates.Location = new System.Drawing.Point(644, 70);
            this.lstBxCandidates.Name = "lstBxCandidates";
            this.lstBxCandidates.Size = new System.Drawing.Size(144, 244);
            this.lstBxCandidates.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(22, 325);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 21);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // dGVVote
            // 
            this.dGVVote.AllowUserToAddRows = false;
            this.dGVVote.AllowUserToDeleteRows = false;
            this.dGVVote.AutoGenerateColumns = false;
            this.dGVVote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVVote.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dGVVote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVVote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dGVVote.DataSource = this.candidatesBindingSource;
            this.dGVVote.Location = new System.Drawing.Point(26, 39);
            this.dGVVote.Name = "dGVVote";
            this.dGVVote.ReadOnly = true;
            this.dGVVote.RowHeadersWidth = 51;
            this.dGVVote.RowTemplate.Height = 24;
            this.dGVVote.Size = new System.Drawing.Size(592, 275);
            this.dGVVote.TabIndex = 5;
            this.dGVVote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVVote_CellContentClick);
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "Candidates";
            this.candidatesBindingSource.DataSource = this.informationDataSetBindingSource;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(642, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numbers;";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(26, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(857, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVVote);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lstBxCandidates);
            this.Controls.Add(this.btnVote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vote";
            this.Load += new System.EventHandler(this.frmVote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource informationDataSetBindingSource;
        private InformationDataSet informationDataSet;
        private InformationDataSetTableAdapters.CandidatesTableAdapter candidatesTableAdapter;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.ListBox lstBxCandidates;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dGVVote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}