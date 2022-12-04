using AbstractFactory.Example_1.Domain.Interface;

namespace AbstractFactory.Example_1.Domain.Entities
{
    public class NYStyleCheesePizza : IPizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Size = 5;
            Toppings = new List<string>();

            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
