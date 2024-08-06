using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_System_21.Classes
{
   sealed class dbconnection
    {
        string conn = "Data Source=.;Initial Catalog=GradingSystem22;Integrated Security=True";

        public DataTable executestoredquery(string query,List<SqlParameter> param)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(param.ToArray());


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }


        public DataTable executequery(string query,bool flag)
        {

            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(query, con);
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
