using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SMP.Models;

namespace SMP.Pages.WardMembers
{
    public class EditModel : PageModel
    {
        private readonly SMP.Models.Planner1Context _context;

        public EditModel(SMP.Models.Planner1Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(WardMember).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WardMemberExists(WardMember.WardMemberID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool WardMemberExists(int id)
        {
            return _context.WardMember.Any(e => e.WardMemberID == id);
        }
    }
}
