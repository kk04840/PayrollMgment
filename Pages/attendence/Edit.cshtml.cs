﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PayrollMgment.Data;
using PayrollMgment.Models;

namespace PayrollMgment.Pages.attendence
{
    public class EditModel : PageModel
    {
        private readonly PayrollMgment.Data.PayrollMgmentContext _context;

        public EditModel(PayrollMgment.Data.PayrollMgmentContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Attendence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttendenceExists(Attendence.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AttendenceExists(int id)
        {
            return _context.Attendence.Any(e => e.Id == id);
        }
    }
}
