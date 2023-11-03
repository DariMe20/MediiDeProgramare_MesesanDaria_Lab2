using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MediiDeProgramare_MesesanDaria_Lab2.Data;
using MediiDeProgramare_MesesanDaria_Lab2.Models;
using MediiDeProgramare_MesesanDaria_Lab2.Models.ViewModels;

namespace MediiDeProgramare_MesesanDaria_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly MediiDeProgramare_MesesanDaria_Lab2.Data.MediiDeProgramare_MesesanDaria_Lab2Context _context;

        public IndexModel(MediiDeProgramare_MesesanDaria_Lab2.Data.MediiDeProgramare_MesesanDaria_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }

        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoryIndexData();

            CategoryData.Categories = await _context.Category
                .Include(i => i.BookCategory)
                 .ThenInclude(bc => bc.Book)
                 .ThenInclude(b => b.Author)
            .OrderBy(i => i.CategoryName)
            .ToListAsync();

            if (id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Categories
                    .Where(i => i.ID == id.Value).Single();
                if (category != null)
                {

                    CategoryData.Books = category.BookCategory
                        .Select(bc => bc.Book)
                        .ToList();
                }
                else
                {

                    CategoryData.Books = Enumerable.Empty<Book>();
                }
            }

            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }

            
        }
    }
}
