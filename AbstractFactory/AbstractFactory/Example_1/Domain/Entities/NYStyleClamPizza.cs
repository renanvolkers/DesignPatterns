using AbstractFactory.Example_1.Domain.Interface;

namespace AbstractFactory.Example_1.Domain.Entities
{
    //Concrete product 
    public class NYStyleClamPizza : IPizza
    {
        public NYStyleClamPizza()
        {
            Name = "NY Style Sauce and Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Size = 5;
            Toppings = new List<string>();

            Toppings.Add("Grated Reggiano Clam");
        }
    }
}
