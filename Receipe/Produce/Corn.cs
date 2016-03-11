using Recipes;

namespace Recipes.Produce
{
    public class Corn : Ingredient, IIngredient
    {
        public Corn()
        {
            UnitPrice = CupOfCorn;
            IsOrganicDiscount = false;
            IsTaxable = false;
        }
    }
}
