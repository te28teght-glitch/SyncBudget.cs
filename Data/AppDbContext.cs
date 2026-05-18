using Microsoft.EntityFrameworkCore;
using SyncBudgetApp.Models;

namespace SyncBudgetApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // Автоматически создаст БД и таблицы при первом запуске
            Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Добавляем начальные категории, если таблица пуста
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Еда", Type = "Expense" },
                new Category { Id = 2, Name = "Транспорт", Type = "Expense" },
                new Category { Id = 3, Name = "Развлечения", Type = "Expense" },
                new Category { Id = 4, Name = "Коммунальные услуги", Type = "Expense" },
                new Category { Id = 5, Name = "Здоровье", Type = "Expense" },
                new Category { Id = 6, Name = "Зарплата", Type = "Income" },
                new Category { Id = 7, Name = "Фриланс", Type = "Income" },
                new Category { Id = 8, Name = "Подарок", Type = "Income" }
            );
        }
    }
}