namespace aspCourses.Models
{
    public class Cheeseburger : Burger
    {
        public Cheeseburger() : base("Cheeseburger")
        {
            Price = 6;
            Ingredients = new List<string> { "bun", "meat", "sause", "cheese" };
        }
    }
}
