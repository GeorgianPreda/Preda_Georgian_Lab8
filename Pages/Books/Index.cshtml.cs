#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Preda_Georgian_Lab8.Data;
using Preda_Georgian_Lab8.Models;

namespace Preda_Georgian_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Preda_Georgian_Lab8.Data.Preda_Georgian_Lab8Context _context;

        public IndexModel(Preda_Georgian_Lab8.Data.Preda_Georgian_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
           Book = await _context.Book.ToListAsync();

        }
    }
}
