using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollMgment.Models
{
    public class Attendence
    {
        // attendense table e de
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Attendence ")]
        public string EAttendence { get; set; }

        [Display(Name = "Date ")]
        public DateTime attendenceDate { get; set; }
    }
}
