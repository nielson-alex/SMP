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
    public class DetailsModel : PageModel
    {
        private readonly SMP.Models.Planner1Context _context;

        public DetailsModel(SMP.Models.Planner1Context context)
        {
            _context = context;
        }

        public WardMember WardMember { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WardMember = await _context.WardMember.FirstOrDefaultAsync(m => m.WardMemberID == id);

            if (WardMember == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
