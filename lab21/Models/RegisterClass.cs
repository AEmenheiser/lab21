using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace lab21.Models
{
    public class RegisterClass
    {
        //I dont think this level of validation will work with the html form, tho I could (probably) be wrong.
        [Required(ErrorMessage = "Enter Name PLease")]
        [MaxLength(20)]
        [RegularExpression(@"^[A-Za-z.\s_-]+$", ErrorMessage = "Invalid Character Input")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter Name PLease")]
        [MaxLength(20)]
        [RegularExpression(@"^[A-Za-z.\s_-]+$", ErrorMessage = "Invalid Character Input")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Date of Birth Required")]
        public DateTime DoB { get; set; }
        [Required(ErrorMessage = "Phone Number Required")]
        public int PhoneNumber { get; set; }
    }
}