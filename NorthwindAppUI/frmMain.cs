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
    public partial class frmMain : Form
    {
        public static BAL.ConnectionString LOGIN_CONNECTION_STRING;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (!frm.OUT_CONNECTION_IS_SUCCESSFUL)
                Application.Exit();
            LOGIN_CONNECTION_STRING = frm.OUT_LOGIN_CONNECTION_STRING;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.AddFormToPanel(new frmCustomers());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.AddFormToPanel(new frmEmployees());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.AddFormToPanel(new frmOrders());
        }

        private void AddFormToPanel(Form frm)
        {
            panel1.Controls.Clear();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        
    }
}
