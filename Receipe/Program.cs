using System;
using System.Collections.Generic;

using Recipes;
using Recipes.MeatPoultry;
using Recipes.Pantry;
using Recipes.Produce;

namespace Recipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipes = new List<Recipe>()
            {
                new Recipe
                    (
                     "Recipe 1",
                      new List<IIngredient>()
                      {
                          new OrganicGarlic() {Quantity = Units.One},
                          new Lemon() {Quantity = Units.One},
                          new OrganicOliverOil() {Quantity = Units.ThreeQuarterCup},
                          new Salt() {Quantity = Units.ThreeQuarterTeaspon},
                          new Pepper() {Quantity = Units.HalfTeaspon}
                      }
                  ),

                new Recipe
                    (
                        "Recipe 2",
                        new List<IIngredient>()
                          {
                              new OrganicGarlic() {Quantity = Units.One},
                              new ChickenBreast() {Quantity = Units.Fours},
                              new OrganicOliverOil() {Quantity = Units.HalfCup},
                              new Vinegar() {Quantity = Units.HalfCup}
                          }
                    ),

                 new Recipe
                    (
                       "Recipe 3",
                        new List<IIngredient>()
                          {
                              new OrganicGarlic() {Quantity = Units.One},
                              new Corn() {Quantity = Units.FourCups},
                              new Bacon() {Quantity = Units.FourSlices},
                              new Pasta() {Quantity = Units.EightOunces},
                              new OrganicOliverOil() {Quantity = Units.OneThirdCup},
                              new Salt() {Quantity = Units.OneTeaspon + Units.OneQuarterTeaspon},
                              new Pepper() {Quantity = Units.ThreeQuarterTeaspon}
                          }
                    )
                 };

            recipes.ForEach(a => Common.RecipePrint(a));
            Console.ReadLine();
        }
    }
}
