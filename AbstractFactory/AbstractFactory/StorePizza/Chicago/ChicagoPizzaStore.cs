namespace AbstractFactory.StorePizza
{
        // Fabric Concrete 

    public class ChicagoPizzaStore : PizzaStoreAbstractFactory
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
