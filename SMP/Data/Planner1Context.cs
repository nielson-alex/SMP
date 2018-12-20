using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SMP.Models
{
    public class Planner1Context : DbContext
    {
        public Planner1Context (DbContextOptions<Planner1Context> options)
            : base(options)
        {
        }

        public DbSet<SMP.Models.Meeting> Meeting { get; set; }
        public DbSet<SMP.Models.WardMember> WardMember { get; set; }
        public DbSet<SMP.Models.Hymn> Hymn { get; set; }
        public DbSet<SMP.Models.BishopricMember> BishopricMember { get; set; }
    }
}
