﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moisin_Andrei_Lab2.Data;
using Moisin_Andrei_Lab2.Models;

namespace Moisin_Andrei_Lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Moisin_Andrei_Lab2.Data.Moisin_Andrei_Lab2Context _context;

        public DetailsModel(Moisin_Andrei_Lab2.Data.Moisin_Andrei_Lab2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
