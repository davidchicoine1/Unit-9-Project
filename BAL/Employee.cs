using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Employee
    {
        DAL.Data dobj;
        public Employee(ConnectionString cs)
        {
            dobj = new DAL.Data(cs.Server, cs.Database, cs.User, cs.Password);
        }

        public int GetNumberOfEmployees()
        {
            return dobj.GetNumberOfEmployees();
        }

        public List<string> GetEmployeeLastNames()
        {
            return dobj.GetEmployeeLastNames();
        }
    }
}
