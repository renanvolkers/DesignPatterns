using AbstractFactory.Example_1.Domain.Interface;

namespace AbstractFactory.Example_1.Domain.Entities
{
    public class EmptyPizza : IPizza
    {
        public EmptyPizza()
        {
            Name = "Empty Pizza";
            Dough = "Empty Pizza";
            Sauce = "Empty Pizza";
            Size = 5;
            Toppings = new List<string>();

            Toppings.Add("Empty");
        }
    }
}
