using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bakery.Data;
using Bakery.Models;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BakeryContext _context;

        public IndexModel(BakeryContext context)
        {
            _context = context;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
