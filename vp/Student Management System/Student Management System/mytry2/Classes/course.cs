using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mytry2.Classes
{
    class course
    {
        int courseid;
        string coursecode;
        string name;
        int totalmarks;

        public int Courseid { get => courseid; 
            
            set=>courseid = value; }
        public string Coursecode { get => coursecode; set => coursecode = value; }
        public string Name { get => name; set => name = value; }
        public int Totalmarks { get => totalmarks; set => totalmarks = value; }

        public void create()
        {

        }
        public void read()
        {

        }
        public void update()
        {

        }
        public void delete()
        {

        }

    }
}
