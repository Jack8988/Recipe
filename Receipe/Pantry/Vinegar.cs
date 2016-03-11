using Recipes;

namespace Recipes.Pantry
{
    public class Vinegar : Ingredient, IIngredient
    {
        public Vinegar()
        {
            UnitPrice = OneCupOfVinegar;
            IsOrganicDiscount = false;
            IsTaxable = true;
        }
    }
}
