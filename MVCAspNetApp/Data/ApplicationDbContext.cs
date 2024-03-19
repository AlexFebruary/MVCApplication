using Microsoft.EntityFrameworkCore;
using MVCAspNetApp.Models;

namespace MVCAspNetApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<QuizQuestionOption> QuizQuestionOptions { get; set; }
        public DbSet<QuizUserAnswer> QuizUserAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<QuizUserAnswer>()
        .HasOne(q => q.QuizQuestion)
        .WithMany()
        .HasForeignKey(q => q.QuizQuestionId)
        .OnDelete(DeleteBehavior.Restrict); // No CASCADE DELETE here

    modelBuilder.Entity<QuizUserAnswer>()
        .HasOne(q => q.QuizQuestionOption)
        .WithMany()
        .HasForeignKey(q => q.QuizQuestionOption_id)
        .OnDelete(DeleteBehavior.Restrict); // No CASCADE DELETE here
}
    }
}