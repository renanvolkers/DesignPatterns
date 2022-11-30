namespace AbstractFactory.StorePizza
{
    public abstract class PizzaStore
    {
       

        public Pizza OrderPizza(TypePizza type)
        {
            Pizza? pizza;
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }

       protected  abstract Pizza CreatePizza(TypePizza type);
    }   
}
