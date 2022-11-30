namespace AbstractFactory.StorePizza
{
    public class TestPizza
    {
        public TestPizza()
        {

        }

        public  string Execute(TypePizza typePizza)
        {
            PizzaStore NYStore = new NYPizzaStore();
            PizzaStore ChicagoStore = new ChicagoPizzaStore();

            Pizza pizza = NYStore.OrderPizza(typePizza);
            System.Console.WriteLine(pizza.StatusDescription);

             pizza = ChicagoStore.OrderPizza(typePizza);
            System.Console.WriteLine(pizza.StatusDescription);

            return pizza?.StatusDescription;
        }
    }
}
