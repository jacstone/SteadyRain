using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SteadyRain.Models
{
    public class StudentModel
    {
        [Key]
        public String StudentId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public SchoolModel School { get; set; }
        public String Major { get; set; }
        public int isActive { get; set; }

    }
}