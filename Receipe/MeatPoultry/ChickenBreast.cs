using Recipes;
namespace Recipes.MeatPoultry
{
    public class ChickenBreast : Ingredient, IIngredient
    {
        public ChickenBreast()
        {
            UnitPrice = OneChickenBreast;
            IsOrganicDiscount = false;
            IsTaxable = true;
        }
    }
}
