using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nendrean_Flavius_Lab02.Data;
using Nendrean_Flavius_Lab02.Models;

namespace Nendrean_Flavius_Lab02.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Nendrean_Flavius_Lab02.Data.Nendrean_Flavius_Lab02Context _context;

        public IndexModel(Nendrean_Flavius_Lab02.Data.Nendrean_Flavius_Lab02Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author != null)
            {
                Author = await _context.Author.ToListAsync();
            }
        }
    }
}
