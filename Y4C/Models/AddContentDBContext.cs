using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Y4C.Models;

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
        public DbSet<Y4C.Models.Account> Account { get; set; }
    }
}
