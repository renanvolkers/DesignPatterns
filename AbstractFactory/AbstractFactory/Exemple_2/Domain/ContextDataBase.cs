using System.Linq.Expressions;

namespace AbstractFactory.Exemple_2.Domain
{
    public interface  ContextDataBase
    {
        public void OnConfiguring();
        public  IQueryable<Product> Get(Expression<Func<Product, bool>> predicate);
    }
}
