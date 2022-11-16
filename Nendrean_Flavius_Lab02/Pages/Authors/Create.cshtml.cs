﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nendrean_Flavius_Lab02.Data;
using Nendrean_Flavius_Lab02.Models;

namespace Nendrean_Flavius_Lab02.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Nendrean_Flavius_Lab02.Data.Nendrean_Flavius_Lab02Context _context;

        public CreateModel(Nendrean_Flavius_Lab02.Data.Nendrean_Flavius_Lab02Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
