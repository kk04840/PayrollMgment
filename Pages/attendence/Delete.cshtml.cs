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
    public class DeleteModel : PageModel
    {
        private readonly PayrollMgment.Data.PayrollMgmentContext _context;

        public DeleteModel(PayrollMgment.Data.PayrollMgmentContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendence = await _context.Attendence.FindAsync(id);

            if (Attendence != null)
            {
                _context.Attendence.Remove(Attendence);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
