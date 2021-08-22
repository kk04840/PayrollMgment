using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PayrollMgment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollMgment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PayrollMgment.Data.PayrollMgmentContext _context;




        private readonly ILogger<IndexModel> _logger;

        public IndexModel(PayrollMgment.Data.PayrollMgmentContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

       
      

        public IList<Employee> Employee { get; set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();

        }

        /*
        public void OnGet()
        {

        }*/



    }
}
