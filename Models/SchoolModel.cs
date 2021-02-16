using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SteadyRain.Models
{
    public class SchoolModel
    {
        [Key]
        public String SchoolId { get; set; }
        public String SchoolName { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String ZipCode { get; set; }

    }
}