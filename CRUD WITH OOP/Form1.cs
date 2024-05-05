using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_WITH_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student ss = new Student();
            ss.Reg(txtName.Text,txtCourse.Text);
            MessageBox.Show("Record Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student a = new Student();
            List<Student> cl = a.get_ALL();
            dataGridView1.DataSource = cl;
        }
    }
}
