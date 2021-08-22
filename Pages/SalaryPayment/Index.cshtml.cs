using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollMgment.Data;
using PayrollMgment.Models;

namespace PayrollMgment.Pages.SalaryPayment
{
    public class IndexModel : PageModel
    {
        private readonly PayrollMgment.Data.PayrollMgmentContext _context;

        public IndexModel(PayrollMgment.Data.PayrollMgmentContext context)
        {
            _context = context;
        }

        public IList<Payment> Payment { get;set; }

        public async Task OnGetAsync()
        {
            Payment = await _context.Payment.ToListAsync();
        }
    }
}
