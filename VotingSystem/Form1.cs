using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VotingSystem
{

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        OleDbConnection connct = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\VSProjects\\VotingSystem\\Information.accdb");
        OleDbCommand commnd = new OleDbCommand();

        private void btnBeCandidate_Click(object sender, EventArgs e)
        {
            frmBeCandidate frmbecandidate = new frmBeCandidate();
            frmbecandidate.Show();
            Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmALogin frmalogin = new frmALogin();
            frmalogin.Show();
            Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmVLogin frmvlogin = new frmVLogin();
            frmvlogin.Show();
            Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            frmVSignIn frmvsignin = new frmVSignIn();
            frmvsignin.Show();
            Visible = false;
        }
    }
}
