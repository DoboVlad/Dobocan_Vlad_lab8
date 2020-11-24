using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dobocan_Vlad_lab8.Data;
using Dobocan_Vlad_lab8.Models;

namespace Dobocan_Vlad_lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Dobocan_Vlad_lab8.Data.Dobocan_Vlad_lab8Context _context;

        public IndexModel(Dobocan_Vlad_lab8.Data.Dobocan_Vlad_lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
