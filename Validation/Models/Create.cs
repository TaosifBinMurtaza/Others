using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Models
{
    public class Create
    {
        [Required(ErrorMessage ="*Name is required")]
        [MinLength(3)]
        [MaxLength(30)]
        //[RegularExpression(@"/^[A-Z a-z .-]+$/i")]
        public string Name { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"[0-9]")]
        public int Id { get; set; }

        [Required]
       
        public DateTime Dob { get; set; }
        [Required]
        public string Profession { get; set; }

        [Required]
        public string[] Hobbies { get; set; }
        public string Gender { get; set; }
    }
}