using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter_5.Models
{
    public class Employee
    {
        [Display(Name = "員工編號")]
        public int Id { get; set; }
        [Display(Name = "員工名稱")]
        public string Name { get; set; }
        [Display(Name = "員工電話")]
        public string Phone { get; set; }
        [Display(Name = "員工信箱")]
        public string Email { get; set; }

    }
}
