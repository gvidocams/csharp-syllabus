using System;
using System.Globalization;

namespace Exercise13
{
    public class Smoothie
    {
        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
        string[] ingredientArray = { "Strawberries", "Banana", "Mango", "Blueberries", "Raspberries", "Apple", "Pineapple" };
        double[] priceArray = { 1.50, 0.50, 2.50, 1.00, 1.00, 1.75, 3.50 };
        public string[] ingredients;

        public Smoothie(string[] ingredients)
        {
            this.ingredients = ingredients;
        }

        public decimal Cost()
        {
            decimal price = 0;

            for (int i = 0; i < ingredients.Length; i++)
            {
                int indexOfIngredientPrice = Array.IndexOf(ingredientArray, ingredients[i]);

                price += (decimal)priceArray[indexOfIngredientPrice];
            }

            return price;
        }

        public string GetCost()
        {
            return Cost().ToString("C", culture);
        }

        public string GetPrice()
        {
            const decimal CostMultiplier = (decimal)1.5;

            decimal price = Cost() + Cost() * CostMultiplier;

            return price.ToString("C", culture);
        }

        public string GetName()
        {
            string[] ingredientCopy = new string[ingredients.Length];

            Array.Copy(ingredients, ingredientCopy, ingredients.Length);
            Array.Sort(ingredientCopy);

            string fusionOrSmoothie = ingredientCopy.Length > 1 ? "Fusion" : "Smoothie";

            string name = "";

            for(int i = 0; i < ingredientCopy.Length; i++)
            {
                ingredientCopy[i] = ingredientCopy[i].Replace("berries", "berry");
            }

            return $"{String.Join(" ", ingredientCopy)} {fusionOrSmoothie}";
        }
    }
}
