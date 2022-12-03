using AbstractFactory.Domain.Interface;
using AbstractFactory.Domain.ValueObj;
using AbstractFactory.Factories.AbstractFactory;

namespace AbstractFactory.StorePizza
{
    public class DependentPizzaStore
    {
        public IPizza CreatePizza(City city, TypePizza typePizza)
        {
            IPizza pizza = null;
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
