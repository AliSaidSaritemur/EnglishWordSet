using EnglishWordSet.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.Data.Contexts
{
    class WordContext :DbContext 
    {
        public DbSet<NWords> Words { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<LearnedWord> LearnedWords { get; set;}

        protected   override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database= EWordEfCore;" +
                "integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LearnedWord>().HasIndex(a => a.wordEnglish).IsUnique(true);
            modelBuilder.Entity<Admin>().HasIndex(a => a.UserName).IsUnique(true);
            modelBuilder.Entity<Admin>().Property(a => a.Password).IsRequired();
            base.OnModelCreating(modelBuilder);
        }

    }
}
