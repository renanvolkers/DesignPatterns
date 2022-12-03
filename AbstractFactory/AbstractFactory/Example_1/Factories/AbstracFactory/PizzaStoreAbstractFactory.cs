using AbstractFactory.Example_1.Domain.Interface;
using AbstractFactory.Example_1.Domain.ValueObj;
using AbstractFactory.StorePizza;

namespace AbstractFactory.Factories.AbstractFactory
{


    //Abstract Factory
    public abstract class PizzaStoreAbstractFactory
    {
       

        public IPizza OrderPizza(TypePizza type)
        {
            IPizza? pizza;
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }

       protected  abstract IPizza CreatePizza(TypePizza type);
    }   
}
