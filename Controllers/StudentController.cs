using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicsAppMVC.Models;
using Microsoft.Extensions.Configuration;//iconfiguration
namespace ElectronicsAppMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IConfiguration configuration;
        string connection;
        StudentRepository repository;
        public StudentController(IConfiguration _configuration) {
            configuration = _configuration;
            connection = configuration.GetConnectionString("dbcon");
            repository = new StudentRepository();
        }
        //student details(raw data)
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id=1,FirstName="Neha",LastName="Bagul",Email="neha@cloudkampus.com",Mobile="45214",Address="Pune"},
                new Student(){ Id=2,FirstName="Amit",LastName="AAnand",Email="amit@cloudkampus.com",Mobile="7845",Address="Banglore"},
                new Student(){ Id=3,FirstName="Natasha",LastName="Dsouza",Email="natasha@cloudkampus.com",Mobile="784578",Address="Mumbai"}
            };
            return View(students);
        }

        //student details(db)
        public IActionResult Details() {
            List<Student> students = repository.GetStudents(connection);
            return View(students);
        }

        //create a new resource student
        [HttpGet]
        // http verb attribute
        //extra info about how the action method will handle the data
        //retrieve info from the server
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        // http verb attribute
        //extra info about how the action method will handle the data
        //sending some info to the server for the processing
        public IActionResult Create(Student student) {
            //no error modelstate=true
            if (ModelState.IsValid)
            {
                return RedirectToAction("Details");
            }
            else {
                //error modelstate=false
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult Register1()
        {
            return View();
        }
        //registeration page for student(tag helper)
        [HttpGet]
        public IActionResult Register() {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Student student)
        {
            return View();
        }
    }
}
