using Entities.Concrete;
using LogAccess;
using LogAccess.services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataAccess.Concrete
{
   internal class WordContext :DbContext 
    {
        public DbSet<NWords> Words { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<LearnedWord> LearnedWords { get; set;}
        public DbSet<RandomWord> RandomWords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try { 
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database= EWordEfCore;" +
                "integrated security=true;");
            }
            catch
            {
                AddLog.systemLogs.Fatal("System couldn't access to DB");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LearnedWord>().HasIndex(a => a.wordEnglish).IsUnique(true);
            modelBuilder.Entity<LearnedWord>().Property(a => a.wordEnglish).HasColumnName("learnedWord_word");
            modelBuilder.Entity<LearnedWord>().Property(a => a.wordTurkish).HasColumnName("learnedWord_meanig");
            modelBuilder.Entity<LearnedWord>().Property(a => a.wordSentence).HasColumnName("learnedWord_sentence");
            modelBuilder.Entity<LearnedWord>().Property(a => a.meaningWordSentence).HasColumnName("learnedWord_meanigSentence");
            modelBuilder.Entity<User>().HasIndex(a => a.UserName).IsUnique(true);
            modelBuilder.Entity<User>().Property(a => a.Password).IsRequired();
            modelBuilder.Entity<User>().Property(a => a.Role).HasDefaultValue("user");

            base.OnModelCreating(modelBuilder);
        }

    }
}
