using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT3.Models
{
    public class appContext : DbContext
    {
        public virtual DbSet<Notas> Notas { get; set; }
    
     

           public appContext(DbContextOptions<appContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new mapNota());

        }
    }
}
