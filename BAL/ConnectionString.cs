using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class ConnectionString
    {
        public string Server;
        public string Database;
        public string User;
        public string Password;

        public ConnectionString(string Server, string Database, string User, string Password)
        {
            this.Server = Server;
            this.Database = Database;
            this.User = User;
            this.Password = Password;
        }

        public bool Test()
        {
            DAL.Data dobj = new DAL.Data(this.Server, this.Database, this.User, this.Password);
            return dobj.TestConnection();
        }
    }
}
