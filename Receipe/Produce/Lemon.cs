using Recipes;

namespace Recipes.Produce
{
    public class Lemon : Ingredient, IIngredient
    {
        public Lemon()
        {
            UnitPrice = OneLemon;
            IsOrganicDiscount = false;
            IsTaxable = false;
        }
    }
}
