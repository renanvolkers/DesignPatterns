namespace AbstractFactory.StorePizza
{
    public class DependentPizzaStore
    {
        public Pizza CreatePizza(City city, TypePizza typePizza)
        {
            Pizza pizza = null;

            if (City.NY.Equals(city))
            {
                var NYStore = new NYPizzaStore();
                pizza = NYStore.OrderPizza(typePizza);
                Console.WriteLine(pizza.StatusDescription);

            }
            else if (City.Chicago.Equals(city))
            {
                var ChicagoStore = new ChicagoPizzaStore();
                pizza = ChicagoStore.OrderPizza(typePizza);
                Console.WriteLine(pizza.StatusDescription);

            }

            return pizza;


        }
    }
}
