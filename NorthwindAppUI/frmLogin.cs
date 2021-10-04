using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindApp
{
    public partial class frmLogin : Form
    {
        public bool OUT_CONNECTION_IS_SUCCESSFUL=false;
        public BAL.ConnectionString OUT_LOGIN_CONNECTION_STRING;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtServerName.Text))
                MessageBox.Show("Please write SQL Server Name.");
            else if (string.IsNullOrEmpty(this.txtDatabaseName.Text))
                MessageBox.Show("Please write Database Name.");
            else if (string.IsNullOrEmpty(this.txtUserName.Text))
                MessageBox.Show("Please write User Name.");
            else
            {
                BAL.ConnectionString cnstr = new BAL.ConnectionString(this.txtServerName.Text, this.txtDatabaseName.Text, this.txtUserName.Text, this.txtPassword.Text);
                if (!cnstr.Test())
                    MessageBox.Show("Database Connection Details are not correct.");
                else
                {
                    this.OUT_CONNECTION_IS_SUCCESSFUL = true;
                    this.OUT_LOGIN_CONNECTION_STRING = cnstr;
                    this.Close();
                }                    
            }

        }
    }
}
