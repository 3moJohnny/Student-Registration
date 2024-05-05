using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CRUD_WITH_OOP
{
    class Student
    {
        public int id { get; set; }
        public string StuName { get; set; }
        public string Course { get; set; }

        public string constring = "Data Source=JUNIOR\\SQLEXPRESS;Initial Catalog=StudentReg;Integrated Security=True";
        public void Reg(string name, string course)

        {
            SqlConnection con = new SqlConnection(constring);
            string sql = "insert into Data(StuName,Course) values('" + name + "','" + course + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }


        public List<Student> get_ALL()
        {
            List<Student> lst = new List<Student>();
            SqlConnection con = new SqlConnection(constring);
            string sql = "Select * From Data";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader redr = cmd.ExecuteReader();
            while(redr.Read())
            {
                Student stu = new Student();
                stu.id = (int)redr["id"];
                stu.StuName = redr["StuName"].ToString();
                stu.Course = redr["Course"].ToString();
                lst.Add(stu);
            }

            return lst;
        }







    }
}
