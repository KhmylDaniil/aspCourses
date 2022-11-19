namespace aspCourses.Models
{
    public class NoOnionBurger : BurgerDecorator
    {
        public NoOnionBurger(Burger burger) : base(burger.Name + " without onion", burger)
        {
            burger.Price = burger.Ingredients.Contains("onion") ? burger.Price - ConstantPrices.OnionPrice : burger.Price;

            burger.Ingredients.Remove("onion");
        }
    }
}
