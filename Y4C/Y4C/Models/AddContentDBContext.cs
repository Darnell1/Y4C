using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Y4C.Models
{
    public class AddContentDBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddContent>()
                .Property(prop => prop.Id)
                .ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }

        public AddContentDBContext(DbContextOptions<AddContentDBContext> options) : base(options) { }
        public DbSet<AddContent> AC { get; set; }
            public DbSet<Survey> Survey { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answer> Answer { get; set; }
    }
}
