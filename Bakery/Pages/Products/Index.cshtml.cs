using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bakery.Data;
using Bakery.Models;
using Microsoft.Extensions.Caching.Memory;

namespace Bakery.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Bakery.Data.BakeryContext _context;
        private readonly IMemoryCache _cache;

        public IndexModel(Bakery.Data.BakeryContext context, IMemoryCache cache)
        {
            _context = context;
            _cache = cache;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
