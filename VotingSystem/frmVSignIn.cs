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
    public partial class frmVSignIn : Form
    {
        public frmVSignIn()
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
                commnd.CommandText = "INSERT INTO Voters([Name], [Age], [Mail], [Password]) VALUES (@Name, @Age, @Mail, @Password)";
                commnd.Parameters.AddWithValue("@Name", txtBxVSName.Text);
                commnd.Parameters.AddWithValue("@Age", txtBxVSAge.Text);
                commnd.Parameters.AddWithValue("@Mail", txtBxVSMail.Text);
                commnd.Parameters.AddWithValue("@Password", txtBxVSPassword.Text);

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
            txtBxVSName.Clear();
            txtBxVSAge.Clear();
            txtBxVSMail.Clear();
            txtBxVSPassword.Clear();
        }
        private void btnVSGetBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmmain = new frmMain();
            frmmain.Show();
        }

        
    }
}
