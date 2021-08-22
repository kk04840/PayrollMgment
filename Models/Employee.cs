using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollMgment.Models
{
    public class Employee
    {
        public int Id { get; set; }
        // name address 
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Address ")]
        public string Address { get; set; }

        // Contat 
        [Display(Name = "Contact ")]
        public int Contact { get; set; }

        [Display(Name = "Salary")]
        public int Salary { get; set; }

        [Display(Name = "Designation")]
        public String Designation { get; set; }





    }
}
