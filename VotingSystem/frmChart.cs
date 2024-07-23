using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VotingSystem
{
    public partial class frmChart : Form
    {
        private OleDbConnection connct = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\VSProjects\\VotingSystem\\Information.accdb");
        private OleDbDataAdapter adapter;
        private DataTable myTable;
        public frmChart()
        {
            InitializeComponent();
        }


        



        private void btnGetBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
        }

        private void LoadAndDisplayVotePercentagePieChart()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\VSProjects\\VotingSystem\\Information.accdb";
            string query = "SELECT Name, Votes FROM Candidates;";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    connection.Close();

                    DisplayVotePercentagePieChart(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DisplayVotePercentagePieChart(DataTable dataTable)
        {
            chrtCandidates.Series.Clear();
            chrtCandidates.Titles.Clear();

            chrtCandidates.Width = 600;
            chrtCandidates.Height = 600;

            ChartArea chartArea = new ChartArea();
            chrtCandidates.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            foreach (DataRow row in dataTable.Rows)
            {
                string candidateName = row["Name"].ToString();
                int voteCount = Convert.ToInt32(row["Votes"]);

                double votePercentage = (double)voteCount / dataTable.AsEnumerable().Sum(r => r.Field<int>("Votes")) * 100;

                series.Points.AddXY(candidateName, votePercentage);
            }

            chrtCandidates.Series.Add(series);
            chrtCandidates.Titles.Add("Vote Percentages");

            chrtCandidates.Invalidate();
        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            LoadAndDisplayVotePercentagePieChart();


        }
    }
}
