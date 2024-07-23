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
    public partial class frmALogin : Form
    {
        
        public frmALogin()
        {
            InitializeComponent();
        }

        OleDbConnection connct = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\VSProjects\\VotingSystem\\Information.accdb");
        OleDbCommand commnd = new OleDbCommand();
        OleDbDataReader dr;

        private void btnALogin_Click(object sender, EventArgs e)
        {
            try
            {
                string predefinedMail = "fatma.kisa@email.com";
                string predefinedPassword = "123as";

                if (txtBxALMail.Text == predefinedMail && txtBxALPassword.Text == predefinedPassword)
                {
                    frmAdmin formadmin = new frmAdmin();
                    formadmin.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Mail or password is incorrect..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }

        private void btnALGetBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmmain = new frmMain();
            frmmain.Show();
        }
    }
}
