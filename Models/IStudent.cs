using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicsAppMVC.Models
{
    //declaring methods(CRUD)
    interface IStudent
    {
        List<Student> GetStudents(string cname);
        void AddStudent(Student student,string cname);
        void UpdateStudent(Student student,string cname);
        void DeleteStudent(int id,string cname);
        Student GetStudentById(int id,string cname);
    }
}
