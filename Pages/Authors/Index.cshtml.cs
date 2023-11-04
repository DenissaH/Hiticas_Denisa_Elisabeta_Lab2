using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hiticas_Denisa_Elisabeta_Lab2.Data;
using Hiticas_Denisa_Elisabeta_Lab2.Models;

namespace Hiticas_Denisa_Elisabeta_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Hiticas_Denisa_Elisabeta_Lab2.Data.Hiticas_Denisa_Elisabeta_Lab2Context _context;

        public IndexModel(Hiticas_Denisa_Elisabeta_Lab2.Data.Hiticas_Denisa_Elisabeta_Lab2Context context)
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
