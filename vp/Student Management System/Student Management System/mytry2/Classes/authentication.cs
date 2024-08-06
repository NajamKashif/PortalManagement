using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace mytry2.Classes
{
    static class authentication
    {
        public static DataTable login(string email, string password,string type)
        {
           
            dbconnection db = new dbconnection();
            string query = $@"select * from  {type} where
            Email='{email}' and Password='{password}'";
            DataTable dt = db.executequery(query, false);
            return dt;
        }
    }
}
