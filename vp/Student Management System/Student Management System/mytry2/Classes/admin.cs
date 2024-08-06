using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace mytry2.Classes
{
    class admin:person
    {
        dbconnection db = new dbconnection();
        public override void create()
        {

            string query = "";
            db.executequery(query, true);
        }
        public override DataTable read()
        {

            string query = "";
          return  db.executequery(query, false);
        }
        public override void update(int id)
        {

            string query = "";
            db.executequery(query, true);
        }
        public override void delete(int id)
        {

            string query = "";
            db.executequery(query, false);
        }
    }
}
