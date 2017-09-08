namespace Products2.Backend.Models
{
    using Domain;

    public class DataContextLocal : DataContext
    {
        public System.Data.Entity.DbSet<Products2.Domain.Category> Categories { get; set; }
    }
}