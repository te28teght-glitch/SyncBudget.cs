using System.ComponentModel.DataAnnotations.Schema;

namespace SyncBudgetApp.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        public int Id {get; set;}
        public decimal Amount {get; set;}
        public string Type {get; set;} = "Income";
        public string Category {get;set;} = "";
        public DateTime Date {get; set;}
        public string Note {get; set;} = "";
    }
}