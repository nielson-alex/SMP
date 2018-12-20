using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMP.Models;

namespace SMP.Pages.WardMembers
{
    public class CreateModel : PageModel
    {
        private readonly SMP.Models.Planner1Context _context;

        public CreateModel(SMP.Models.Planner1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public WardMember WardMember { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.WardMember.Add(WardMember);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}