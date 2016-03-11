using Recipes;
namespace Recipes.Pantry
{
    public class OrganicOliverOil : Ingredient, IIngredient
    {   
        public OrganicOliverOil()
        {
            UnitPrice = OneCupOfOrganicOliveOil;
            IsOrganicDiscount = true;
            IsTaxable = true;
        }
    }
}
