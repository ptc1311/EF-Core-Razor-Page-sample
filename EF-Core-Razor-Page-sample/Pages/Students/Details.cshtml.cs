﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly EF_Core_Razor_Page_sample.Data.SchoolContext _context;

        public DetailsModel(EF_Core_Razor_Page_sample.Data.SchoolContext context)
        {
            _context = context;
        }

      public Student Student { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FirstOrDefaultAsync(m => m.ID == id);
            if (student == null)
            {
                return NotFound();
            }
            else 
            {
                Student = student;
            }
            return Page();
        }
    }
}
