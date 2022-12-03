using AbstractFactory.Example_1.Domain.Interface;
using System.Text;

namespace AbstractFactory.Example_1.Domain.Entities
{
    public class ChicagoStyleCheesePizza : IPizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum tomato Sauce";
            Size = 5;

            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            var sb = new StringBuilder(StatusDescription);
            sb.AppendLine("Cutting the pizza into square slices");
            StatusDescription = sb.ToString();
        }
    }
}
