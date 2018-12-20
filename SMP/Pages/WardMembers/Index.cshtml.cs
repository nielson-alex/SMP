using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SMP.Models;

namespace SMP.Pages.WardMembers
{
    public class IndexModel : PageModel
    {
        private readonly SMP.Models.Planner1Context _context;

        public IndexModel(SMP.Models.Planner1Context context)
        {
            _context = context;
        }

        public IList<WardMember> WardMember { get;set; }

        public async Task OnGetAsync()
        {
            WardMember = await _context.WardMember.ToListAsync();
        }
    }
}
