using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectWebsite.Models;

namespace ProjectWebsite.Views.Home
{
    public class IndexModel : PageModel
    {
        private readonly ProjectWebsite.Models.OutdoorParadiseContext _context;

        public IndexModel(ProjectWebsite.Models.OutdoorParadiseContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee
                .Include(e => e.BranchCodeNavigation)
                .Include(e => e.Dept)
                .Include(e => e.Job)
                .Include(e => e.Manager).ToListAsync();
        }
    }
}
