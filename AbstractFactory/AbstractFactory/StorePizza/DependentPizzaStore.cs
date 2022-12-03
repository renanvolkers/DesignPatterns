namespace AbstractFactory.StorePizza
{
    public class DependentPizzaStore
    {
        public Pizza CreatePizza(City city, TypePizza typePizza)
        {
            Pizza pizza = null;
            PizzaStoreAbstractFactory factory;
            
            if (City.NY.Equals(city))
            {
                factory = new NYPizzaStore();
                pizza = factory.OrderPizza(typePizza);
                Console.WriteLine(pizza.StatusDescription);

            }
            else if (City.Chicago.Equals(city))
            {
                factory = new ChicagoPizzaStore();
                pizza = factory.OrderPizza(typePizza);
                Console.WriteLine(pizza.StatusDescription);

            }

            return pizza;


        }
    }
}
