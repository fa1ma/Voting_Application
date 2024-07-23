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
using System.Windows.Input;

namespace VotingSystem
{
    public partial class frmBeCandidate : Form
    {
        public frmBeCandidate()
        {
            InitializeComponent();
        }

        OleDbConnection connct = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\VSProjects\\VotingSystem\\Information.accdb");
        OleDbCommand commnd = new OleDbCommand();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                connct.Open();
                commnd.Connection = connct;
                commnd.CommandText = "INSERT INTO Candidates([Name], [Age], [Mail], [Password], [Number]) VALUES (@Name, @Age, @Mail, @Password, @Number)";
                commnd.Parameters.AddWithValue("@Name", txtBxCName.Text);
                commnd.Parameters.AddWithValue("@Age", txtBxCAge.Text);
                commnd.Parameters.AddWithValue("@Mail", txtBxCMail.Text);
                commnd.Parameters.AddWithValue("@Password", txtBxCPassword.Text);
                commnd.Parameters.AddWithValue("@Number", txtBxCNumber.Text);

                commnd.ExecuteNonQuery();
                MessageBox.Show("Member inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connct.Close();
            }
            txtBxCName.Clear();
            txtBxCAge.Clear();
            txtBxCMail.Clear();
            txtBxCPassword.Clear();
            txtBxCNumber.Clear();
        }

        private void btnBCGetBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmmain = new frmMain();
            frmmain.Show();
        }
    }
}
