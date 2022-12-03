namespace AbstractFactory.StorePizza
{
\\Concrete Product

    public class ChicagoPizzaStore : PizzaStore
    {
       protected override  Pizza CreatePizza(TypePizza type)
        {

            if (type.Equals(TypePizza.Cheese))
            {
                return new ChicagoStyleCheesePizza();
            }
            else return null;
        }
    }   
}
