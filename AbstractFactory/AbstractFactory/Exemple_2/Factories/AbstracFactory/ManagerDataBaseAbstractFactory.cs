using AbstractFactory.Exemple_2.Domain;

namespace AbstractFactory.Exemple_2.Factories.AbstracFactory
{
    //Abstract Factory
    public abstract class ManagerDataBaseAbstractFactory
    {
       public abstract ContextDataBase CreateDbContext();
    }

}
