using AbstractFactory.Exemple_2.Domain;
using AbstractFactory.Exemple_2.Factories.AbstracFactory;

namespace AbstractFactory.Exemple_2.Factories
{
    public class ContextSqlDBFactory : ManagerDataBaseAbstractFactory
    {
        public override ContextDataBase CreateDbContext()
        {
            throw new NotImplementedException();
        }
    }
}
