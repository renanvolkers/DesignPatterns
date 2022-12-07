using System.Text;

namespace AbstractFactory.Example_1.Domain.Interface
{
    public abstract class IPizzaContriuit
    {
        //Product 
        public string? Name { get; set; }
        public string? Dough { get; set; }
        public string? Sauce { get; set; }
        public int Size { get; set; }
        public string? StatusDescription { get; set; }

        public List<string> Toppings { get; set; }

        public void Prepare()
        {
            var sb = new StringBuilder(StatusDescription);

            sb.AppendLine("Preparing " + Name);
            sb.AppendLine("Tossing dough..");
            sb.AppendLine("Adding sauce..");
            sb.AppendLine("Adding Topping");

            Toppings.ForEach(topping => sb.AppendLine("  " + topping));
            StatusDescription = sb.ToString();
        }

        public void Bake()
        {
            var sb = new StringBuilder(StatusDescription);
            sb.AppendLine("Bake for 25 minutes at 350");
            StatusDescription = sb.ToString();
        }
        public void Box()
        {
            var sb = new StringBuilder(StatusDescription);
            sb.AppendLine("Place pizza in official PizzaStore box");
            StatusDescription = sb.ToString();
        }
        public virtual void Cut()
        {
            var sb = new StringBuilder(StatusDescription);
            sb.AppendLine("Cutting the pizza into diagonal slices");
            StatusDescription = sb.ToString();
        }

    }
}
