using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollMgment.Models
{
     // payment table
    public class Payment
    {

        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Salary ")]
        public int Salary { get; set; }

        [Display(Name = "Date ")]
        public DateTime paymentDate { get; set; }
    }
}
