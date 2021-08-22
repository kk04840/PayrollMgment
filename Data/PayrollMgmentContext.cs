using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PayrollMgment.Models;

namespace PayrollMgment.Data
{
    public class PayrollMgmentContext : DbContext
    {
        public PayrollMgmentContext (DbContextOptions<PayrollMgmentContext> options)
            : base(options)
        {
        }

        public DbSet<PayrollMgment.Models.Employee> Employee { get; set; }

        public DbSet<PayrollMgment.Models.Attendence> Attendence { get; set; }

        public DbSet<PayrollMgment.Models.Payment> Payment { get; set; }
    }
}
