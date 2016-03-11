using Recipes;

namespace Recipes.Pantry
{
    public class Salt : Ingredient, IIngredient
    {
        public Salt()
        {
            UnitPrice = OneTeaspoonOfSalt;
            IsOrganicDiscount = false;
            IsTaxable = true;
        }
    }
}
