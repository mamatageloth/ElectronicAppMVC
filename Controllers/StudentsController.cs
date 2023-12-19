using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ElectronicsAppMVC.Models;

namespace ElectronicsAppMVC.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IConfiguration configuration;
        string connection;
        StudentRepository repository;
        public StudentsController(IConfiguration _configuration) {
            configuration = _configuration;
            connection = configuration.GetConnectionString("dbcon");
            repository = new StudentRepository();
        }
        // GET: StudentsController
        public ActionResult Index()
        {
            List<Student> students = repository.GetStudents(connection);
            return View(students);
        }

        // GET: StudentsController/Details/5
        public ActionResult Details(int id)
        {
            Student student = repository.GetStudentById(id, connection);
            return View(student);
        }
        //create a new resource
        // GET: StudentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                if (ModelState.IsValid) {

                    repository.AddStudent(student, connection);
                }
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Edit/5
        public ActionResult Edit(int id)
        {
            Student student = repository.GetStudentById(id, connection);
            return View(student);
        }

        // POST: StudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            try
            {
                repository.UpdateStudent(student, connection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Delete/5
        public ActionResult Delete(int id)
        {
            Student student = repository.GetStudentById(id, connection);
            return View(student);
        }

        // POST: StudentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Student student)
        {
            try
            {
                repository.DeleteStudent(student.Id, connection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
