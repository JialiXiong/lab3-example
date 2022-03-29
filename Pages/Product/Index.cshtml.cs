#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab3_example.Models;

namespace lab3_example.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly StoreDBContext _context;

        public IndexModel(StoreDBContext context)
        {
            _context = context;
        }

        public IList<Lab3_example.Models.Product> Product { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
