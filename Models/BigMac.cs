namespace aspCourses.Models
{
    public class BigMac : Burger
    {
        public BigMac() : base("BigMac")
        {
            Price = ConstantPrices.BigMacPrice;
            Ingredients = new List<string> { "bun", "meat", "sause", "cheese", "onion", "tomtoes" };
        }
    }
}
