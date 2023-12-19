using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ElectronicsAppMVC.Models
{
    public class Employee
    { 
        [Display(Name ="Employee Id")]
        public int employeeId { get; set; }
        [Display(Name ="First Name")]
        public string employeeFName { get; set; }
        [Display(Name = "Last Name")]
        public string employeeLName { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string employeeEmail { get; set; }
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string employeeAddress { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string employeepassword { get; set; }
        [Display(Name = "Technologies")]
        public Technology Technology { get; set; }
        [Display(Name = "Departments")]
        public Department Department { get; set; }
    }
    public enum Technology { 
    HTML,
    CSS,
    JS,
    CSharp,
    ASPNET,
    COREMVC
    }
    public enum Department
    {
        HR,
        Admin,
        IT,
        Sales
    }
}
