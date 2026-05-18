using Microsoft.EntityFrameworkCore;
using SyncBudgetApp.Models;

namespace SyncBudgetApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Transaction> Transaktion {get;set;}
        public DbSet<Category> Categories {get; set;}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, Name = "Еда", Type = "Expense"},
                new Category {Id = 2, Name = "Транспорт", Type = "Expense"},
                new Category {Id = 3, Name = "Развлечения", Type = "Expense"},
                new Category {Id = 4, Name = "Зарплата", Type = "Income"}
            );
        }
    }
}