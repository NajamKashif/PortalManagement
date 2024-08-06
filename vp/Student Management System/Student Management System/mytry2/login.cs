using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mytry2.Classes;

namespace mytry2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            //BackColor = Color.CadetBlue;
        }

        private void label2_Click_3(object sender, EventArgs e)
        {
            ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = authentication.login(textBox1.Text, textBox2.Text, comboBox1.Text);
            if (dt.Rows.Count==1)
            {
                if (dt.Rows.Count == 1)
                {
                    if (comboBox1.Text == "student")
                    {
                        studenthome s = new studenthome();
                        s.Show();
                    }
                    else if (comboBox1.Text == "teacher")
                    {
                        teacherhome t = new teacherhome();
                        t.Show();
                    }
                    else
                    {
                        adminhome a = new adminhome();
                        a.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Email or Password is Invalid");
                              
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            BackColor = Color.CadetBlue;
        }
    }
}
