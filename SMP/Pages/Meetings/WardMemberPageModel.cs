using SMP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace SMP.Pages.Meetings
{
    public class WardMemberPageModel : PageModel
    {
        public SelectList WardMemberNameSL { get; set; }

        public void PopulateWardMembersDropDownList(Planner1Context _context,
            object selectedWardMember = null)
        {
            var wardMembersQuery = from w in _context.WardMember
                                   orderby w.FirstName // Sort by name.
                                   select w;

            WardMemberNameSL = new SelectList(wardMembersQuery.AsNoTracking(),
                        "FirstName", "Name", selectedWardMember);
        }
    }
}
