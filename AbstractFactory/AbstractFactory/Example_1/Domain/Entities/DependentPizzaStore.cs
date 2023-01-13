using AbstractFactory.Example_1.Domain.Interface;
using AbstractFactory.Example_1.Domain.ValueObj;
using AbstractFactory.Factories.AbstractFactory;
using AbstractFactory.StorePizza;

namespace AbstractFactory.Example_1.Domain.Entities
{
    public class DependentPizzaStore
    {
        public IPizza CreatePizza(City city, TypePizza typePizza)
        {
            IPizza? pizza = new EmptyPizza();
            PizzaStoreAbstractFactory factory;

            if (City.NY.Equals(city))
            {
                factory = new NYPizzaStoreFactory();
                pizza = factory.OrderPizza(typePizza);
                Console.WriteLine(pizza.StatusDescription);

            }
            else if (City.Chicago.Equals(city))
            {
                factory = new ChicagoPizzaStoreFactory();
                pizza = factory.OrderPizza(typePizza);
                Console.WriteLine(pizza.StatusDescription);

            }

            return pizza;


        }
    }
}
