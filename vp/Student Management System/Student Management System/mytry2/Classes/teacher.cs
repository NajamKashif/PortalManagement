using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace mytry2.Classes
{
   class teacher:person
    {
        string designation;
        dbconnection db = new dbconnection();

        public string Designation { get => designation; set => designation = value; }
        public override void create()
        {
            string query = $@"insert into teacher
                (Name,Age,Phone,Email,Password)
                values('{this.Name}','{this.Age}','{this.Email}','{this.Password}','{this.designation}')";
                   
            db.executequery(query, true);
        }
        public override DataTable read()
        {

            string query = "select * from teacher";
           return db.executequery(query, false);

        }
        public override void update(int id)
        {

            string query = $@"update teacher
                set Name='{this.Name}',Age='{this.Age}',
                Phone='{this.Phone}',Email='{this.Email}',
                Password={this.Password}',Designation='{this.designation}',
                where teacheID={id}";
               
            db.executequery(query, true);
        }
        public override void delete(int id)
        {

            string query = "delete from teacher where teacherID={id}";
            db.executequery(query, false);
        }
    }
}
