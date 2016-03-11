using System;
using System.Configuration;
using Recipes;

namespace Recipes
{
    public class Ingredient : IIngredient
    {
        //Produce
        internal decimal GloveOfOrganicGarlic { get; set; }
        internal decimal CupOfCorn { get; set; }
        internal decimal OneLemon { get; set; }

        //Meat & poultry
        internal decimal OneChickenBreast { get; set; }
        internal decimal OneSliceOfBacon { get; set; }

        //Pantry
        internal decimal OneOunceOfPasta { get; set; }
        internal decimal OneCupOfOrganicOliveOil { get; set; }
        internal decimal OneCupOfVinegar { get; set; }
        internal decimal OneTeaspoonOfSalt { get; set; }
        internal decimal OneTeaspoonOfPepper { get; set; }

        //Interface
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public bool IsOrganicDiscount { get; set; }
        public bool IsTaxable { get; set; }
        public decimal SaleTaxRate { get; set; }
        public decimal DiscountRate { get; set; }

        public Ingredient()
        {
            GloveOfOrganicGarlic = Convert.ToDecimal( ConfigurationManager.AppSettings["ONE_CLOVE_OF_ORGANIC_GARLIC"]);
            CupOfCorn = Convert.ToDecimal(ConfigurationManager.AppSettings["ONE_CUP_OF_CORN"]);
            OneLemon = Convert.ToDecimal(ConfigurationManager.AppSettings["ONE_LEMON"]);

            OneChickenBreast = Convert.ToDecimal(ConfigurationManager.AppSettings["ONE_CHICKEN_BREAST"]);
            OneSliceOfBacon = Convert.ToDecimal(ConfigurationManager.AppSettings["ONE_SLICE_OF_BACON"]);

            OneOunceOfPasta = Convert.ToDecimal(ConfigurationManager.AppSettings["ONE_OUNCE_OF_PASTA"]);
            OneCupOfOrganicOliveOil = Convert.ToDecimal(ConfigurationManager.AppSettings["ONE_CUP_OF_ORGANIC_OIL"]);
            OneCupOfVinegar = Convert.ToDecimal(ConfigurationManager.AppSettings["ONE_CUP_OF_VINEGAR"]);
            OneTeaspoonOfSalt = Convert.ToDecimal(ConfigurationManager.AppSettings["ONE_TEASPOON_OF_SALT"]);
            OneTeaspoonOfPepper = Convert.ToDecimal(ConfigurationManager.AppSettings["ONE_TEASPOON_OF_PEPPER"]);

            SaleTaxRate = Convert.ToDecimal(ConfigurationManager.AppSettings["SALE_TAX"]);
            DiscountRate = Convert.ToDecimal(ConfigurationManager.AppSettings["DISCOUNT_RATE"]);

        }
    }
}
