using AbstractFactory.Domain.Interface;
using AbstractFactory.Domain.ValueObj;
using AbstractFactory.Factories.AbstractFactory;

namespace AbstractFactory.StorePizza
{
        // Factory Concrete 

    public class ChicagoPizzaStoreFactory : PizzaStoreAbstractFactory
    {
       protected override  IPizza CreatePizza(TypePizza type)
        {

            if (type.Equals(TypePizza.Cheese))
            {
                return new ChicagoStyleCheesePizza();
            }
            else return null;
        }
    }   
}
