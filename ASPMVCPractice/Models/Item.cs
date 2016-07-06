using System.Data.Entity;

namespace ASPMVCPractice.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool isEditable { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}