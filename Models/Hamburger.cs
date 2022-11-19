namespace aspCourses.Models
{
    public class Hamburger : Burger
    {
        public Hamburger() : base("Hamburger")
        {
            Price = 5;
            Ingredients = new List<string> { "bun", "meat", "sause" };
        }
    }
}
