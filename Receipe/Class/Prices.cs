using System.Collections.Generic;

namespace Receipe.Class
{
    public class Prices
    {
   
        //Produce
        public static readonly decimal ONE_CLOVE_OF_ORGANIC_GARLIC = 0.67m;
        public static readonly decimal ONE_CUP_OF_CORN = 0.87m;
        public static readonly decimal ONE_LEMON = 2.03m;

        //Meat/poultry
        public static readonly decimal ONE_CHICKEN_BREAST = 2.19m;
        public static readonly decimal ONE_SLICE_OF_BACON = 0.24m;

        //Pantry
        public static readonly decimal ONE_OUNCE_OF_PASTA = 0.31m;
        public static readonly decimal ONE_CUP_OF_ORGANIC_OIL = 1.92m;
        public static readonly decimal ONE_CUP_OF_VINEGAR = 1.26m;
        public static readonly decimal ONE_TEASPOON_OF_SALT = 0.16m;
        public static readonly decimal ONE_TEASPOON_OF_PEPPER = 0.17m;

        //Tax rate
        public readonly decimal SALE_TAX = 0.086m;

        //Organic discount
        public readonly decimal ORGANIC_DISCOUNT = 0.05m;

        public Dictionary<string, decimal> RecipeMap =
            new Dictionary<string, decimal>()
            {
                ["HALF_CUP"] = 0.5m,
                ["THREE_QUARTER_CUP"] = 0.75m,
                ["ONE_CUP"]=  1.0m,
                ["ONE_OUNCE"] = 1.0m,
                ["ONE_TEASPOON"] = 1.0m,
                ["ONE_PIECE"] = 1.0m,
                
            };
    }
}
