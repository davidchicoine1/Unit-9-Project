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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnGetCustomersData_Click(object sender, EventArgs e)
        {
            BAL.Customer cst = new BAL.Customer(frmMain.LOGIN_CONNECTION_STRING);
            txtNumber.Text = cst.GetNumberOfCustomers().ToString();
            lbxNames.DataSource = cst.GetCustomerLastNames();
        }
    }
}
