using Recipes;

namespace Recipes.Pantry
{
    public class Pepper : Ingredient, IIngredient
    {
        public Pepper()
        {
            UnitPrice = OneTeaspoonOfPepper;
            IsOrganicDiscount = false;
            IsTaxable = true;
        }
    }
}
