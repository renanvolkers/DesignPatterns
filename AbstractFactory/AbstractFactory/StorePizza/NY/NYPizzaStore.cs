namespace AbstractFactory.StorePizza
{
//Concrete product 
    public class NYPizzaStore: PizzaStore
    {
       protected override  Pizza CreatePizza(TypePizza type)
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
