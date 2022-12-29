using AbstractFactory.Exemple_2.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AbstractFactory.Exemple_2.Factories.Products
{
    public class ContextSqlEE : DbContext,  ContextDataBase
    {
        public string ConnectionString { get; set; }
        public string? DatabaseName { get; set; }

        protected  void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
        public DbSet<Product> Product { get; set; }

        public IQueryable<Product> Get(Expression<Func<Product, bool>> predicate) => Product.AsQueryable().Where(predicate);

        public void OnConfiguring()
        {
            throw new NotImplementedException();
        }
    }
}
