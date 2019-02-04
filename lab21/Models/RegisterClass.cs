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

        [Key]
        public int ID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        //I dont think this level of validation will work with the html form, tho I could (probably) be wrong.
        
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

      
        public string Email { get; set; }
       
        public int PhoneNumber { get; set; }


    }
}