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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void btnGetOrdersData_Click(object sender, EventArgs e)
        {
            BAL.Order cst = new BAL.Order(frmMain.LOGIN_CONNECTION_STRING);
            txtNumber.Text = cst.GetNumberOfOrders().ToString();
            lbxNames.DataSource = cst.GetOrderCustomerID();
        }
    }
}
