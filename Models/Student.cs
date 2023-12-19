using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ElectronicsAppMVC.Models
{
    public class Student
    {
        [Display(Name ="Student Id")]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Please provide first name")]
        [StringLength(20, ErrorMessage = "First name should not exceed more than 20 characters")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please provide last name")]
        public string LastName { get; set;}
       
        [Required(ErrorMessage = "Please provide email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please provide mobile number")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Please provide address details")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public string Image { get; set; }
    }
}
