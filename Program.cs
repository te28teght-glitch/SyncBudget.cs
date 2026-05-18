using Microsoft.EntityFrameworkCore;
using SyncBudgetApp.Data;

namespace SyncBudgetApp;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        var dbPath = Path.Combine(Application.UserAppDataPath, "budget.db");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
        
        using (var db = new AppDbContext(optionsBuilder.Options))
        {
            db.Database.EnsureCreated();
        }
        
        Application.Run(new Form1());
    }
}