using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Customer
    {
        DAL.Data dobj;
        public Customer(ConnectionString cs)
        {
            dobj = new DAL.Data(cs.Server, cs.Database, cs.User, cs.Password);
        }

        public int GetNumberOfCustomers()
        {
            return dobj.GetNumberOfCustomers();
        }

        public List<string> GetCustomerLastNames()
        {
            return dobj.GetCustomerLastNames();
        }

    }
}
