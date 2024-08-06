using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_System_21.Classes
{
  static  class Authentication
    {

        public static DataTable login(string email, string password, string type)
        {
            //   "select * from student where\r\n         
            //     Email='ali@gmail.com' and Password='12345' OR 'x'='x'"
            dbconnection db = new dbconnection();
            List<SqlParameter> param = new List<SqlParameter>()
            {
           new SqlParameter("@email",email),//0
           new SqlParameter("@password",password),//1
             new SqlParameter("@type",type)//2
            };
        
            string query = $@"login__user";

            DataTable dt=   db.executestoredquery(query,param);
            return dt;
        }
    }
}
