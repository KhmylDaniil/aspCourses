using System.Runtime.CompilerServices;

namespace aspCourses.Models
{
    abstract public class BurgerDecorator : Burger
    {
        protected Burger Burger { get; set; }

        protected BurgerDecorator(string name, Burger burger): base(name)
        {
            this.Burger = burger;
        }

        public override Burger GetBurger() => this.Burger;
    }
}
