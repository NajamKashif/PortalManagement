using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace mytry2.Classes
{
    sealed class dbconnection
    {
        string conn = "Data Source=DESKTOP-V072GQH;Initial Catalog=studentmanagementsystem;Integrated Security=True";
        public DataTable executequery(string query, bool flag)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(query ,con);
            if (flag)
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return null;
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
    }
}
