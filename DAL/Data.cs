using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class Data
    {
        SqlConnection conn;

        public Data(string Server, string Database, string User, string Password)
        {
            string ConStr = "Data Source=" + Server + ";";
            ConStr += "Initial Catalog=" + Database + ";";
            ConStr += "User ID=" + User + ";";
            ConStr += "Password=" + Password + ";";
            this.conn = new SqlConnection(ConStr);
        }

        public bool TestConnection()
        {
            bool connected = true;
            try
            {
                this.conn.Open();
            }
            catch
            {
                connected = false;
            }
            if (this.conn.State == ConnectionState.Open)
                this.conn.Close();
            return connected;
        }

        //Customers
        public int GetNumberOfCustomers()
        {
            int nc = 0;
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(*) from Customers";
            da.SelectCommand = cmd;
            try
            {
                this.conn.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                    nc = Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (this.conn.State == ConnectionState.Open)
                this.conn.Close();
            return nc;
        }

        public List<string> GetCustomerLastNames()
        {
            List<string> names = new List<string>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select SUBSTRING(ContactName, CHARINDEX(' ', ContactName) + 1, LEN(ContactName)) AS LastName from Customers";
            try
            {
                this.conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        names.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (this.conn.State == ConnectionState.Open)
                this.conn.Close();

            return names;
        }

        //Employees
        public int GetNumberOfEmployees()
        {
            int nc = 0;
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(*) from Employees";
            da.SelectCommand = cmd;
            try
            {
                this.conn.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                    nc = Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (this.conn.State == ConnectionState.Open)
                this.conn.Close();
            return nc;
        }

        public List<string> GetEmployeeLastNames()
        {
            List<string> names = new List<string>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select LastName from Employees";
            try
            {
                this.conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        names.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (this.conn.State == ConnectionState.Open)
                this.conn.Close();

            return names;
        }

        //Orders

        public int GetNumberOfOrders()
        {
            int nc = 0;
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(*) from Orders";
            da.SelectCommand = cmd;
            try
            {
                this.conn.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                    nc = Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (this.conn.State == ConnectionState.Open)
                this.conn.Close();
            return nc;
        }

        public List<string> GetOrderCustomerID()
        {
            List<string> names = new List<string>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select CustomerID from Orders";
            try
            {
                this.conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        names.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (this.conn.State == ConnectionState.Open)
                this.conn.Close();

            return names;
        }

    }
}
