using System;

namespace Recipes
{
    public static class Common
    {
        public static decimal GetSevenRound(decimal input)
        {         
            int temp = Decimal.ToInt32 (GetCentRound(input) * 100.0m);
            var mode = temp % 7;            
            return (temp + 7 - mode)/100.0m;            
        }

        public static decimal GetCentRound(decimal input)
        {
            return Math.Round(input * 100 + 0.5m) / 100m;
        }

        //public static void RecipePrint(string name, decimal tax, decimal discount, decimal total)
        //updated on 2/20/2017
        //branch update later at 11:13 AM
        public static void RecipePrint(Recipe recipe)
        {
            Console.WriteLine(recipe.RecipeName);
            Console.WriteLine();
            Console.Write("\t");
            Console.WriteLine(string.Format("Tax = {0}", recipe.Tax().ToString("C")));

            Console.Write("\t");
            Console.WriteLine(string.Format("Discount = ({0})", recipe.Discount().ToString("C")));

            Console.Write("\t");
            Console.WriteLine(string.Format("Total = {0}", recipe.TotalCost().ToString("C")));
            Console.WriteLine();
        }
    }
}
