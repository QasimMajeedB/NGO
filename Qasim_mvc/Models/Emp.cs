using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Qasim_mvc.Models
{
    public class Emp
    {
        [Key]
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; }
        [StringLength(20)]
        public string email { get; set; }
        public string address { get; set; }
    }
}