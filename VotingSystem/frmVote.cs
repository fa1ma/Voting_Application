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

namespace VotingSystem
{
    public partial class frmVote : Form
    {
        public string LoginMail { get; set; }
        public string LoginPassword { get; set; }


        public frmVote()
        {
            InitializeComponent();
            InitializeCandidates();
        }
        OleDbConnection connct = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\VSProjects\\VotingSystem\\Information.accdb");

        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\VSProjects\\VotingSystem\\Information.accdb";
        private string selectedCandidate;

        private OleDbDataAdapter adapter;
        private DataTable myTable;
        private void frmVote_Load(object sender, EventArgs e)
        {
            adapter = new OleDbDataAdapter("SELECT * FROM Candidates", connct);
            myTable = new DataTable();
            adapter.Fill(myTable);
            dGVVote.DataSource = myTable;
            lblResult.Visible = false;
        }

        private void InitializeCandidates()
        {
            // Adayları Access veritabanından çekin
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT Number FROM Candidates";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable candidates = new DataTable();
                    adapter.Fill(candidates);

                    // DataTable'daki No sütunundaki değerleri ListBox'a ekleyin
                    foreach (DataRow row in candidates.Rows)
                    {
                        lstBxCandidates.Items.Add(row["Number"].ToString());
                    }
                }
            }
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            // frmVLogin formundan değişkenlere erişim
            if (!string.IsNullOrEmpty(LoginMail) && !string.IsNullOrEmpty(LoginPassword))
            {
                // Voter bilgileri
                string voterMail = LoginMail;
                string voterPassword = LoginPassword;

                // Aday bilgileri (örneğin, lstBxCandidates.SelectedItem'dan alınabilir)
                string selectedCandidateNumber = (lstBxCandidates.SelectedItem != null) ? lstBxCandidates.SelectedItem.ToString() : "";

                if (!string.IsNullOrEmpty(selectedCandidateNumber))
                {
                    // Seçilen adayın "Vote" bilgisini 1 arttırma
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string updateCandidateQuery = "UPDATE Candidates SET [Votes] = [Votes] + 1 WHERE [Number] = @Number";

                        using (OleDbCommand updateCandidateCommand = new OleDbCommand(updateCandidateQuery, connection))
                        {
                            updateCandidateCommand.Parameters.AddWithValue("@Number", selectedCandidateNumber);

                            try
                            {
                                updateCandidateCommand.ExecuteNonQuery();
                            }
                            catch (OleDbException ex)
                            {
                                MessageBox.Show("Hata oluştu (Update Candidate): " + ex.Message);
                            }
                        }
                    }

                    // Oy veren kişinin bilgilerini güncelleme
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string updateVoterQuery = "UPDATE Voters SET VoteWho = @VoteWho WHERE Mail = @Mail";

                        using (OleDbCommand updateVoterCommand = new OleDbCommand(updateVoterQuery, connection))
                        {
                            updateVoterCommand.Parameters.AddWithValue("@VoteWho", selectedCandidateNumber);
                            updateVoterCommand.Parameters.AddWithValue("@Mail", voterMail);

                            try
                            {
                                updateVoterCommand.ExecuteNonQuery();
                            }
                            catch (OleDbException ex)
                            {
                                MessageBox.Show("Hata oluştu (Update Voter): " + ex.Message);
                            }
                        }
                    }

                    lblResult.Visible = true;
                    lblResult.Text = "Oyunuz " + selectedCandidateNumber + " numaralı aday için verildi.";
                }
                else
                {
                    MessageBox.Show("Lütfen bir aday seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Giriş yapılmamış.");
            }
        }







        //lstBxCandidates

        private void cmbBxVote_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dGVVote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVLogin frmvlogin = new frmVLogin();
            frmvlogin.Show();
        }
    }
}
