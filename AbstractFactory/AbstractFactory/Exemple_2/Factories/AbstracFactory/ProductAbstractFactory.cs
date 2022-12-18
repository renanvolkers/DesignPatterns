using Microsoft.EntityFrameworkCore;

namespace AbstractFactory.Exemple_2.Factories.AbstracFactory
{
    //Abstract Factory
    public abstract class ProductAbstractFactory
    {
       protected abstract void OnModelCreating(ModelBuilder modelBuilder);
    }

}
