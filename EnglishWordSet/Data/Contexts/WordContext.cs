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
        protected   override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database= EWordEfCore;" +
                "integrated security=true;");
        }
        
    }
}
