using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace mytry2.Classes
{
    abstract class person
    {
        int id;
        string name;
        int age;
        string phone;
        string email;
        string password;

     public int ID
        {
            set
            {
                if(value<=0)
                {
                    throw new Exception("Id cannot be <=0");
                }
                id = value;
            }
            get
            {
                return id;
            }
        }
       
        public string Name
        {
            set
            {
                if(value==null || value=="")
                {
                    //throw new Exception("Please Provide Name");
                }
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Age
        {
            set
            {
                if(value<=0)
                {
                    throw new Exception("Age cannot be Negative ");
                }
                age = value;
            }
            get
            {
                return age;
            }
        }
   
        public string Phone
        {
            set
            {
                if (value == "" || value == null)
                {
                    throw new Exception("Please Provide Phone ");
                }
                phone = value;
            }
            get
            {
                return phone;
            }
        }

        public string Email
        {
            set
            {
                if (value == "" || value == null)
                {
                    throw new Exception("Please Provide Email ");
                }
                email = value;
            }
            get
            {
                return email;
            }
        }

        public string Password
        {
            set
            {
                if (value == "" || value == null)
                {
                    throw new Exception("Please Provide Email ");
                }
                password = value;
            }
            get
            {
                return password;
            }
        }



        
        public abstract void create();
        public abstract DataTable read();
        public abstract void update(int id);
        public abstract void delete(int id);
    }
}
