using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab21.Models
{
    public class RegisterClass
    {

        
        public int ID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        //I dont think this level of validation will work with the html form, tho I could (probably) be wrong.
        
        [Required(ErrorMessage ="Required")]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }


    }
}