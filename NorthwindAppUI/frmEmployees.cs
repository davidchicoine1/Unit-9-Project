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
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void btnGetEmployeesData_Click(object sender, EventArgs e)
        {
            BAL.Employee cst = new BAL.Employee(frmMain.LOGIN_CONNECTION_STRING);
            txtNumber.Text = cst.GetNumberOfEmployees().ToString();
            lbxNames.DataSource = cst.GetEmployeeLastNames();
        }
    }
}
