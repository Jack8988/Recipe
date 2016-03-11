using Recipes;

namespace Recipes.Pantry
{
    public class Pasta : Ingredient, IIngredient
    {
        public Pasta()
        {
            UnitPrice = OneOunceOfPasta;
            IsOrganicDiscount = false;
            IsTaxable = true;
        }
    }
}
