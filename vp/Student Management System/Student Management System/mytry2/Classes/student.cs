using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace mytry2.Classes
{
    class student:person
    {
        dbconnection db = new dbconnection();
        public override void create()
        {

            string query = $@"insert into student
                (Name,Age,Phone,Email,Password)
                values('{this.Name}',{this.Age},'{this.Phone}'
                ,'{this.Email}','{this.Password}')"; 
                
            db.executequery(query, true);
        }
        public override DataTable read()
        {
            string query = "select * from student";
            return db.executequery(query, false);

        }
        public override void update(int id)
        {
            string query = $@"update student
                set Name='{this.Name}',Age={this.Age},
        Phone='{this.Phone}',Email='{this.Email}',
        Password='{this.Password}'
               where  id={id}";
            db.executequery(query, true);
        }
        public override void delete(int id)
        {
            string query = $"delete from student where id={id}";
            db.executequery(query, false);

        }

    }
}
