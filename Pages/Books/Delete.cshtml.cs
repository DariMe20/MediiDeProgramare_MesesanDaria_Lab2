﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MediiDeProgramare_MesesanDaria_Lab2.Data;
using MediiDeProgramare_MesesanDaria_Lab2.Models;

namespace MediiDeProgramare_MesesanDaria_Lab2.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly MediiDeProgramare_MesesanDaria_Lab2.Data.MediiDeProgramare_MesesanDaria_Lab2Context _context;

        public DeleteModel(MediiDeProgramare_MesesanDaria_Lab2.Data.MediiDeProgramare_MesesanDaria_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            Book = await _context.Book.Include(b => b.Author).FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
   
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }
            var book = await _context.Book.FindAsync(id);

            if (book != null)
            {
                Book = book;
                _context.Book.Remove(Book);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
