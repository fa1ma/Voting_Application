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
    public partial class frmVLogin : Form
    {

        private OleDbConnection cnnct = new OleDbConnection();
        OleDbDataReader dr;
        public frmVLogin()
        {
            InitializeComponent();
        }

        OleDbConnection connct = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\VSProjects\\VotingSystem\\Information.accdb");
        OleDbCommand commnd = new OleDbCommand();
        

        private void btnVLGetBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmmain = new frmMain();
            frmmain.Show();
        }

        private void btnVLogin_Click_1(object sender, EventArgs e)
        {

            connct.Open();
            commnd.Connection = connct;
            
            commnd.CommandText = "SELECT * FROM Voters WHERE Mail = '" + txtBxVLMail.Text + "' AND Password = '" + txtBxVLPassword.Text + "'";
            dr = commnd.ExecuteReader();
            if (dr.Read())
            {
                frmVote frmvote = new frmVote();
                frmvote.LoginMail = txtBxVLMail.Text;
                frmvote.LoginPassword = txtBxVLPassword.Text;
                frmvote.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Mail or password is incorrect..");
            }
            connct.Close();
        }
    }
}
