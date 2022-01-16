#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Preda_Georgian_Lab8.Data;
using Preda_Georgian_Lab8.Models;

namespace Preda_Georgian_Lab8.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Preda_Georgian_Lab8.Data.Preda_Georgian_Lab8Context _context;

        public CreateModel(Preda_Georgian_Lab8.Data.Preda_Georgian_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }


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
