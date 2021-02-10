using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyBazarPOSApp.DAL
{
    class DBAccess
    {
        private static SqlConnection objConnection;
        private static SqlDataAdapter objDataAdapter;

        private static void OpenConnection()
        {
            try
            {
                if (objConnection == null)
                {
                    objConnection = new SqlConnection(@"Data Source=LAPTOP-BIA7GPHB\SQLEXPRESS;Initial Catalog=MyBazarPOS;Integrated Security=True");
                    objConnection.Open();
                }
                else
                {
                    if (objConnection.State != System.Data.ConnectionState.Open)
                    {
                        objConnection = new SqlConnection(@"Data Source=LAPTOP-BIA7GPHB\SQLEXPRESS;Initial Catalog=MyBazarPOS;Integrated Security=True");
                        objConnection.Open();
                    }
                }
            }
            catch
            {

            }
        }
        private static void CloseConnection()
        {
            try
            {
                if(!(objConnection == null))
                {
                    objConnection.Close();
                    objConnection.Dispose();
                }
            }
            catch
            {

            }
        }
        public static DataTable FillDataTable(string query, DataTable Table)
        {
            try
            {
                OpenConnection();
                objDataAdapter = new SqlDataAdapter(query, objConnection);
                objDataAdapter.Fill(Table);
                objDataAdapter.Dispose();
                CloseConnection();
                return Table;

            }
            catch
            {
                return null;
            }
        }
    }

}
