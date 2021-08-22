﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly PayrollMgment.Data.PayrollMgmentContext _context;

        public DetailsModel(PayrollMgment.Data.PayrollMgmentContext context)
        {
            _context = context;
        }

        public Payment Payment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Payment = await _context.Payment.FirstOrDefaultAsync(m => m.Id == id);

            if (Payment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
