using System.Collections.Generic;
using System.Linq;

namespace Recipes
{
    public class Recipe
    {
        public string RecipeName { get; set; }

        public  List<IIngredient> Items { get; set; }

        private Recipe() { }
        public Recipe(string name, List<IIngredient> items )
        {
            RecipeName = name;
            Items = items;
        }

        public decimal Tax()
        {
            decimal result = Items.Where(a => a.IsTaxable).Sum(a=> a.Quantity * a.UnitPrice *  a.SaleTaxRate);
            return Common.GetSevenRound(result);
        }

        public decimal Discount()
        {
            decimal result = Items.Where(a => a.IsOrganicDiscount).Sum(a => a.Quantity * a.UnitPrice * a.DiscountRate);            
            return Common.GetCentRound(result);
        }

        public decimal TotalCost()
        {
            var total = Items.Sum(a => a.UnitPrice*a.Quantity);
            return Common.GetCentRound(total) + Tax() - Discount();
        }
    }
}
