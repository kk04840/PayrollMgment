using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollMgment.Data;
using PayrollMgment.Models;

namespace PayrollMgment.Pages.attendence
{
    public class DetailsModel : PageModel
    {
        private readonly PayrollMgment.Data.PayrollMgmentContext _context;

        public DetailsModel(PayrollMgment.Data.PayrollMgmentContext context)
        {
            _context = context;
        }

        public Attendence Attendence { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendence = await _context.Attendence.FirstOrDefaultAsync(m => m.Id == id);

            if (Attendence == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
