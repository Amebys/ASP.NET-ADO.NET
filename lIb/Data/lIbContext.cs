using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lIb.Models;

namespace lIb.Data
{
    public class lIbContext : DbContext
    {
        public lIbContext (DbContextOptions<lIbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<lIb.Models.Book> Book { get; set; } = default!;
        public DbSet<lIb.Models.Members> Members { get; set; } = default!;
    }
}
