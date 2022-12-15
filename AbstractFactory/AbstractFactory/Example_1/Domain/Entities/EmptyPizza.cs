using AbstractFactory.Example_1.Domain.Interface;
using System.Text;

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
        public override void Cut()
        {
            var sb = new StringBuilder(StatusDescription);
            sb.AppendLine("Cutting the pizza into diagonal slices");
            StatusDescription = sb.ToString();
        }
    }
}
