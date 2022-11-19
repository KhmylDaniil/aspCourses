namespace aspCourses.Models
{
    public abstract class Burger
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<string> Ingredients { get; set; }

        public int Price { get; set; }

        public Burger(string name)
        {
            Name = name;
            Ingredients = new();
            Price = 0;
        }

        public virtual Burger GetBurger() => this;
    }
}
