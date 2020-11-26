using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrainingMSHR.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Insert Your Name")]
        [MaxLength(3, ErrorMessage = "Your Name has more than 3 character")]
        // Validation on Model in ASP.Net MVC
        public string Name { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}