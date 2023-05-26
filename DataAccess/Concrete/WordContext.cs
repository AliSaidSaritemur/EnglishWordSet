using Entities.Concrete;
using LogAccess;
using LogAccess.services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DataAccess.Concrete
{
   internal class WordContext :DbContext 
    {
        public DbSet<NWords> Words { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<LearnedWord> LearnedWords { get; set;}
        public DbSet<RandomWord> RandomWords { get; set; }
        public DbSet<TrWord> TrWords { get; set; }
        public DbSet<UserTexts> _UserTexts { get; set; }
        public DbSet<UserGameScore> _UserGameScores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try { 
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database= EWordEfCore;" +
                "integrated security=true;");
                optionsBuilder
        .ConfigureWarnings(b => b.Ignore(RelationalEventId.AmbientTransactionWarning));
            }
            catch
            {
                AddLog.systemLogs.Fatal("System couldn't access to DB");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrWord>().HasIndex(a => a.English).IsUnique(true);
            modelBuilder.Entity<LearnedWord>().HasIndex(a => a.wordEnglish).IsUnique(true);
            modelBuilder.Entity<LearnedWord>().Property(a => a.wordEnglish).HasColumnName("learnedWord_word");
            modelBuilder.Entity<LearnedWord>().Property(a => a.wordTurkish).HasColumnName("learnedWord_meanig");
            modelBuilder.Entity<LearnedWord>().Property(a => a.wordSentence).HasColumnName("learnedWord_sentence");
            modelBuilder.Entity<LearnedWord>().Property(a => a.meaningWordSentence).HasColumnName("learnedWord_meanigSentence");
            modelBuilder.Entity<User>().HasIndex(a => a.UserName).IsUnique(true);
            modelBuilder.Entity<UserTexts>().HasIndex(a => a.UserName).IsUnique(true);
            modelBuilder.Entity<User>().Property(a => a.Password).IsRequired();
            modelBuilder.Entity<TrWord>().Property(a => a.English).IsRequired();
            modelBuilder.Entity<TrWord>().Property(a => a.Turkish).IsRequired();
            modelBuilder.Entity<User>().Property(a => a.Role).HasDefaultValue("user");
            modelBuilder.Entity<TrWord>().Property(a => a.level).HasDefaultValue(1);
            modelBuilder.Entity<UserGameScore>().Property(a => a.LastLetterGameBestScore).HasDefaultValue(0);
            modelBuilder.Entity<User>().ToTable(tb=>tb.HasTrigger("UserTextAdding"));
            modelBuilder.Entity<User>().ToTable(tb => tb.HasTrigger("UserGameScoreAdding"));
            base.OnModelCreating(modelBuilder);
        }

    }
}
