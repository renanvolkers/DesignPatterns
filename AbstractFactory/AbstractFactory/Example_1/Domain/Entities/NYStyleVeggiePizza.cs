using AbstractFactory.Example_1.Domain.Interface;

namespace AbstractFactory.Example_1.Domain.Entities
{//Concrete product 
    public class NYStyleVeggiePizza : IPizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "NY Style Sauce and Veggie Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Size = 5;
            Toppings = new List<string>();

            Toppings.Add("Grated Veggie Veggie");
        }
    }
}
