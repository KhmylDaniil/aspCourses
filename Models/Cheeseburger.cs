namespace aspCourses.Models
{
    public class Cheeseburger : Burger
    {
        public Cheeseburger() : base("Cheeseburger")
        {
            Price = ConstantPrices.CheeseburgerPrice;
            Ingredients = new List<string> { "bun", "meat", "sause", "cheese" };
        }
    }
}
