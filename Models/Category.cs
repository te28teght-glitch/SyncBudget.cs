using System.ComponentModel.DataAnnotations.Schema;

namespace SyncBudgetApp.Models
{
    [Table("Category")]
    public class Category
    {
        public int Id {get; set;}
        public string Name {get; set;} = "";
        public string Type {get; set;} = "Income";
    }
}