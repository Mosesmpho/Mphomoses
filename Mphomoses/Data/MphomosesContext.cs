using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mphomoses.Models;

namespace Mphomoses.Data
{
    public class MphomosesContext : DbContext
    {
        public MphomosesContext (DbContextOptions<MphomosesContext> options)
            : base(options)
        {
        }

        public DbSet<Mphomoses.Models.Learners> Learners { get; set; } = default!;

        public DbSet<Mphomoses.Models.Facilitators> Facilitators { get; set; } = default!;

        public DbSet<Mphomoses.Models.Courses> Courses { get; set; } = default!;
    }
}
