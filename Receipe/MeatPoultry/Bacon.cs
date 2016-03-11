using Recipes;

namespace Recipes.MeatPoultry
{
    public class Bacon : Ingredient, IIngredient
    {
        public Bacon()
        {
            UnitPrice = OneSliceOfBacon;
            IsOrganicDiscount = false;
            IsTaxable = true;
        }
    }
}
