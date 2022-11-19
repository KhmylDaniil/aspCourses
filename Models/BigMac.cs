namespace aspCourses.Models
{
    public class BigMac : Burger
    {
        public BigMac() : base("BigMac")
        {
            Price = 10;
            Ingredients = new List<string> { "bun", "meat", "sause", "cheese", "onion", "tomtoes" };
        }
    }
}
