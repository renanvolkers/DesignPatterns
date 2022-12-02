namespace AbstractFactory.StorePizza
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Size =5;

            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
