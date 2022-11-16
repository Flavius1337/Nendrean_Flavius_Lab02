using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nendrean_Flavius_Lab02.Data;
using Nendrean_Flavius_Lab02.Models;

namespace Nendrean_Flavius_Lab02.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Nendrean_Flavius_Lab02.Data.Nendrean_Flavius_Lab02Context _context;

        public DetailsModel(Nendrean_Flavius_Lab02.Data.Nendrean_Flavius_Lab02Context context)
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

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
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