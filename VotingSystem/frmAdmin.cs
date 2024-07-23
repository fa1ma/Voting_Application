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
    public partial class frmAdmin : Form
    {
        private readonly Dictionary<int, Dictionary<string, object>> previousCellValues = new Dictionary<int, Dictionary<string, object>>();
        public frmAdmin()
        {
            InitializeComponent();
        }

        OleDbConnection connct = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\VSProjects\\VotingSystem\\Information.accdb");
        OleDbCommand commnd = new OleDbCommand();


        //--VIEW--
        private void viewCandidates()
        {
            try
            {
                if (connct.State != ConnectionState.Open)
                {
                    connct.Open();
                }
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Candidates", connct);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dGVCandidates.DataSource = dt;
                SetColumnDisplayIndex("ID", 0);
                SetColumnDisplayIndex("Name", 1);
                SetColumnDisplayIndex("Age", 2);
                SetColumnDisplayIndex("Mail", 3);
                SetColumnDisplayIndex("No", 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error showing members: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connct.State == ConnectionState.Open)
                {
                    connct.Close();
                }
            }
        }
        private void SetColumnDisplayIndex(string columnName, int displayIndex)
        {
            if (dGVCandidates.Columns.Contains(columnName))
            {
                dGVCandidates.Columns[columnName].DisplayIndex = displayIndex;
            }
        }


        private void btnAView_Click(object sender, EventArgs e)
        {
            viewCandidates();
        }

        private OleDbDataAdapter adapter;
        private DataTable myTable;
        private void frmAdmin_Load(object sender, EventArgs e)
        {

            adapter = new OleDbDataAdapter("SELECT * FROM Candidates", connct);
            myTable = new DataTable();
            adapter.Fill(myTable);
            dGVCandidates.DataSource = myTable;
        }

        //--INSERT--
        private void btnAInsert_Click(object sender, EventArgs e)
        {
            try
            {
                connct.Open();
                commnd.Connection = connct;
                commnd.CommandText = "";
                commnd.Parameters.Clear();
                commnd.CommandText = "INSERT INTO Candidates([Name], [Age], [Mail], [Password], [Number]) VALUES (@Name, @Age, @Mail, @Password, @Number)";
                commnd.Parameters.AddWithValue("@Name", txtBxAName.Text);
                commnd.Parameters.AddWithValue("@Age", txtBxAAge.Text);
                commnd.Parameters.AddWithValue("@Mail", txtBxAMail.Text);
                commnd.Parameters.AddWithValue("@Password", txtBxAPassword.Text);
                commnd.Parameters.AddWithValue("@Number", txtBxANumber.Text);

                commnd.ExecuteNonQuery();
                MessageBox.Show("Member inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewCandidates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connct.Close();
            }
            txtBxAName.Clear();
            txtBxAAge.Clear();
            txtBxAMail.Clear();
            txtBxAPassword.Clear();
            txtBxANumber.Clear();
        }

        private void btnADelete_Click(object sender, EventArgs e)
        {
            connct.Open();
            commnd.Connection = connct;
            commnd.CommandText = "DELETE FROM Candidates WHERE ID=" + txtBxADelete.Text;
            commnd.ExecuteNonQuery();
            connct.Close();
            txtBxADelete.Clear();
            viewCandidates();
        }

        private void btnASaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                connct.Open();
                OleDbCommand updateCommand = new OleDbCommand("UPDATE Candidates SET [Name]=?, [Age]=?, [Mail]=?, [Password]=?, [Number]=? WHERE [ID]=?", connct);

                updateCommand.Parameters.Add("Name", OleDbType.VarChar, 255, "Name");
                updateCommand.Parameters.Add("Age", OleDbType.Integer, 0, "Age");
                updateCommand.Parameters.Add("Mail", OleDbType.VarChar, 255, "Mail");
                updateCommand.Parameters.Add("Password", OleDbType.VarChar, 255, "Password");
                updateCommand.Parameters.Add("Number", OleDbType.Integer, 0, "Number");
                updateCommand.Parameters.Add("ID", OleDbType.Integer, 0, "ID");

                adapter.UpdateCommand = updateCommand;

                foreach (DataRow row in myTable.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        row.AcceptChanges();
                        row.SetModified();
                    }
                }

                adapter.Update(myTable);
                MessageBox.Show("Değişiklikler başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                connct.Close();
            }

        }

        private void btnALogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmmain = new frmMain();
            frmmain.Show();
        }


        private void btnChart_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChart frmchart = new frmChart();
            frmchart.Show();
        }

        //fatma.kisa@email.com











    }
}
