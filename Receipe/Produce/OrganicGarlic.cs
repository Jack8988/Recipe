using Recipes;

namespace Recipes.Produce
{
    public class OrganicGarlic : Ingredient, IIngredient
    {
        public OrganicGarlic()
        {
            UnitPrice = GloveOfOrganicGarlic;
            IsOrganicDiscount = true;
            IsTaxable = false;
        }
    }
}
