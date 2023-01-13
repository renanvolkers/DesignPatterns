using AbstractFactory.Example_1.Domain.Entities;
using AbstractFactory.Example_1.Domain.Interface;
using AbstractFactory.Example_1.Domain.ValueObj;
using AbstractFactory.Factories.AbstractFactory;

namespace AbstractFactory.StorePizza
{
    // Factory Concrete 

    public class ChicagoPizzaStoreFactory : PizzaStoreAbstractFactory
    {
       protected override  IPizza? CreatePizza(TypePizza type)
        {

            if (type.Equals(TypePizza.Cheese))
            {
                return new ChicagoStyleCheesePizza();
            }
            else return new EmptyPizza();
        }
    }   
}
