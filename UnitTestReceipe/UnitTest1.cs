using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Recipes;
using Recipes.MeatPoultry;
using Recipes.Pantry;
using Recipes.Produce;

namespace UnitTestRecipe
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestRecipe1SaleTax()
        {
           
            //Arrange
            var recipe1 = new Recipe
                      (
                       "Recipe 1",
                        new List<IIngredient>()
                        {
                          new OrganicGarlic() {Quantity = 1.0m},
                          new Lemon() {Quantity = 1.0m},
                          new OrganicOliverOil() {Quantity = 0.75m}, //tax
                          new Salt() {Quantity = 0.75m}, //tax
                          new Pepper() {Quantity = 0.5m} //tax
                        }
                    );
            //Act
            //manuall tax calc:            
            decimal taxItemsTotal = 0.75m * 1.92m + 0.75m * 0.16m + 0.5m * 0.17m;
            var taxCalc = Common.GetSevenRound(taxItemsTotal * 0.086m);
            var result = recipe1.Tax();

            //Assert
            Assert.AreEqual(taxCalc, result);
        }


        [TestMethod]
        public void TestRecipe1()
        {
            //Arrange
            var recipe1 = new Recipe
                    (
                        "Recipe 2",
                          new List<IIngredient>()
                          {
                              new OrganicGarlic() {Quantity = Units.One},
                              new Lemon() {Quantity = Units.One},
                              new OrganicOliverOil() {Quantity = Units.ThreeQuarterCup},
                              new Salt() {Quantity = Units.ThreeQuarterTeaspon},
                              new Pepper() {Quantity = Units.HalfTeaspon}
                          }
                    );
            //Act 
            var result = recipe1.TotalCost();
            //Assert
            Assert.AreEqual(4.45m, result);
        }

        [TestMethod]
        public void TestRecipe2()
        {
            //Arrange
            var recipe2 =
                 new Recipe
                    (
                       "Recipe 3",
                        new List<IIngredient>()
                          {
                              new OrganicGarlic() {Quantity = Units.One},
                              new ChickenBreast() {Quantity = Units.Fours},
                              new OrganicOliverOil() {Quantity = Units.HalfCup},
                              new Vinegar() {Quantity = Units.HalfCup}
                          }
                    );
            //Act
            var result = recipe2.TotalCost();

            //assert
            Assert.AreEqual(11.84m, result);
        }


        [TestMethod]
        public void TestRecipe3()
        {
            //Arrange
            var recipe3 =
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
                    );

            //Act
            var result = recipe3.TotalCost();


            //Assert
            Assert.AreEqual(8.91m, result);

        }

        [TestMethod]
        public void TestEmptyRecipe()
        {          
           //var recipe = new Recipe();
        }
    }
}
