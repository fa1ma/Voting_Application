namespace VotingSystem
{
    partial class frmChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChart));
            this.chrtCandidates = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationDataSet = new VotingSystem.InformationDataSet();
            this.btnGetBack = new System.Windows.Forms.Button();
            this.candidatesTableAdapter = new VotingSystem.InformationDataSetTableAdapters.CandidatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtCandidates
            // 
            this.chrtCandidates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrtCandidates.ChartAreas.Add(chartArea1);
            this.chrtCandidates.DataSource = this.candidatesBindingSource;
            legend1.Name = "Legend1";
            this.chrtCandidates.Legends.Add(legend1);
            this.chrtCandidates.Location = new System.Drawing.Point(11, 25);
            this.chrtCandidates.Margin = new System.Windows.Forms.Padding(2);
            this.chrtCandidates.Name = "chrtCandidates";
            this.chrtCandidates.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtCandidates.Series.Add(series1);
            this.chrtCandidates.Size = new System.Drawing.Size(570, 326);
            this.chrtCandidates.TabIndex = 0;
            this.chrtCandidates.Text = "CCart";
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "Candidates";
            this.candidatesBindingSource.DataSource = this.informationDataSet;
            // 
            // informationDataSet
            // 
            this.informationDataSet.DataSetName = "InformationDataSet";
            this.informationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGetBack
            // 
            this.btnGetBack.Location = new System.Drawing.Point(11, 359);
            this.btnGetBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetBack.Name = "btnGetBack";
            this.btnGetBack.Size = new System.Drawing.Size(62, 32);
            this.btnGetBack.TabIndex = 1;
            this.btnGetBack.Text = "get back";
            this.btnGetBack.UseVisualStyleBackColor = true;
            this.btnGetBack.Click += new System.EventHandler(this.btnGetBack_Click);
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(592, 399);
            this.Controls.Add(this.btnGetBack);
            this.Controls.Add(this.chrtCandidates);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChart";
            this.Load += new System.EventHandler(this.frmChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtCandidates;
        private System.Windows.Forms.Button btnGetBack;
        private InformationDataSet informationDataSet;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private InformationDataSetTableAdapters.CandidatesTableAdapter candidatesTableAdapter;
    }
}