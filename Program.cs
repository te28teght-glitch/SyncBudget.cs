using SyncBudgetApp;
using SyncBudgetApp.Data;
using Microsoft.EntityFrameworkCore;

namespace SyncBudgetApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                
                // Создаём контекст для проверки БД
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                var dbPath = Path.Combine(Application.UserAppDataPath, "budget.db");
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
                
                using (var context = new AppDbContext(optionsBuilder.Options))
                {
                    context.Database.EnsureCreated();
                }
                
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске: {ex.Message}\n\n{ex.StackTrace}", 
                    "Критическая ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }
    }
}