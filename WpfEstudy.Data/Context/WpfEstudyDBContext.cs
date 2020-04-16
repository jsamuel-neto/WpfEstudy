using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Infrastructure.Context
{
    public class WpfEstudyDBContext : DbContext
    {
        public WpfEstudyDBContext(DbContextOptions<WpfEstudyDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfigurationsFromAssembly(typeof(WpfEstudyDBContext).Assembly);
            model.HasDefaultSchema("public");
            base.OnModelCreating(model);
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
