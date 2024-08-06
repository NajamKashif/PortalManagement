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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Azure;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void read()
        {
            student s = new student();
            dataGridView1.DataSource = s.read();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.Name = textBox2.Text;
            s.Age =  Convert.ToInt32( textBox3.Text);
            s.Phone = textBox4.Text;
            s.Email = textBox5.Text;
            s.Password = textBox6.Text;
            //s.bid.Bid = 5;
            s.create();
            read();
            //To Clear The Text Boxes after adding record
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            read();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.delete(id);
            read();
            MessageBox.Show("Record has been Deleted Successfully!");
        }
        int id;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            //textBox6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.Name = textBox2.Text;
            s.Age = Convert.ToInt32(textBox3.Text);
            s.Phone = textBox4.Text;
            s.Email = textBox5.Text;
            s.Password = textBox5.Text;
            //s.bid.Bid = 5;

            s.update(id);
            read();
            MessageBox.Show("Record has been Updated Successfully!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
        }
    }
}
