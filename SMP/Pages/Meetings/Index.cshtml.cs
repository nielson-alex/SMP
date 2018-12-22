using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SMP.Models;

namespace SMP.Pages.Meetings
{
    public class IndexModel : PageModel
    {
        private readonly SMP.Models.Planner1Context _context;

        public IndexModel(SMP.Models.Planner1Context context)
        {
            _context = context;
        }

        public string SubjectSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Meeting> Meeting { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            SubjectSort = String.IsNullOrEmpty(sortOrder) ? "Subject1_desc" : "";
            DateSort = sortOrder == "MeetingDate" ? "MeetingDate_desc" : "MeetingDate";
            CurrentFilter = searchString;

            IQueryable<Meeting> ID = from m in _context.Meeting
                                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                ID = ID.Where(m => m.Subject1.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "Subject1_desc":
                    ID = ID.OrderByDescending(m => m.Subject1);
                    break;
                case "MeetingDate":
                    ID = ID.OrderBy(m => m.MeetingDate);
                    break;
                case "MeetingDate_desc":
                    ID = ID.OrderByDescending(m => m.MeetingDate);
                    break;
                default:
                    ID = ID.OrderBy(s => s.MeetingDate);
                    break;
            }

            Meeting = await ID.AsNoTracking().ToListAsync();
            //Meeting = await _context.Meeting.ToListAsync();
        }
    }
}
