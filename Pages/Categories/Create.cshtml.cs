﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moisin_Andrei_Lab2.Data;
using Moisin_Andrei_Lab2.Models;

namespace Moisin_Andrei_Lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Moisin_Andrei_Lab2.Data.Moisin_Andrei_Lab2Context _context;

        public CreateModel(Moisin_Andrei_Lab2.Data.Moisin_Andrei_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
