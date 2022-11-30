using System.Text;

namespace AbstractFactory.StorePizza
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum tomato Sauce";

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