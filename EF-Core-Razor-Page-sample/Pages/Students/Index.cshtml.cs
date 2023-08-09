using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EF_Core_Razor_Page_sample.Data;
using EF_Core_Razor_Page_sample.Models;

namespace EF_Core_Razor_Page_sample.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly EF_Core_Razor_Page_sample.Data.SchoolContext _context;

        public IndexModel(EF_Core_Razor_Page_sample.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
