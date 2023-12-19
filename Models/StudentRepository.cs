using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ElectronicsAppMVC.Models
{
    public class StudentRepository : IStudent
    {
        //fetch all student details from student table
        public List<Student> GetStudents(string cname)
        {
            SqlConnection con = new SqlConnection(cname);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from student", con);
            List<Student> students = new List<Student>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                Student student = new Student();
                student.Id =Convert.ToInt32(dr[0]);
                student.FirstName = dr[1].ToString();
                student.LastName = dr[2].ToString();
                student.Email = dr[3].ToString();
                student.Mobile = dr[4].ToString();
                student.Address = dr[5].ToString();
                student.Image = dr["Image"].ToString();
                students.Add(student);
            }
            con.Close();
            return students;

        }
        public void AddStudent(Student student, string cname)
        {
            using (SqlConnection con = new SqlConnection(cname))
            {
                SqlCommand cmd = new SqlCommand("spAddStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@Mobile", student.Mobile);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteStudent(int id, string cname)
        {
            using (SqlConnection con = new SqlConnection(cname))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Student GetStudentById(int id, string cname)
        {
            Student student = new Student();

            using (SqlConnection con = new SqlConnection(cname))
            {
                string sqlQuery = "SELECT * FROM Student WHERE Id= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    student.Id = Convert.ToInt32(rdr["Id"]);
                    student.FirstName = rdr["FirstName"].ToString();
                    student.LastName = rdr["LastName"].ToString();
                    student.Email = rdr["Email"].ToString();
                    student.Mobile = rdr["Mobile"].ToString();
                    student.Address = rdr["Address"].ToString();
                }
            }
            return student;
        }

        

        public void UpdateStudent(Student student,string cname)
        {
            using (SqlConnection con = new SqlConnection(cname))
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@Mobile", student.Mobile);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
