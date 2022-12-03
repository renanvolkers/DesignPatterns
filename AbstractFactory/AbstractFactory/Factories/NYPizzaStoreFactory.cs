using AbstractFactory.Domain.Entities;
using AbstractFactory.Domain.Interface;
using AbstractFactory.Domain.ValueObj;
using AbstractFactory.Factories.AbstractFactory;

namespace AbstractFactory.StorePizza
{
//Factory Concrete  
    public class NYPizzaStoreFactory: PizzaStoreAbstractFactory
    {
       protected override  IPizza CreatePizza(TypePizza type)
        {
            if (type.Equals(TypePizza.Cheese))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals(TypePizza.Viggie))
            {
                return new NYStyleVeggiePizza();
            }
            else if (type.Equals(TypePizza.Clam))
            {
                return new NYStyleClamPizza();
            }
            else if (type.Equals(TypePizza.Pepperoni))
            {
                return new NYStylePepperoniPizza();
            }
            else return null;
        }
    }   
}
