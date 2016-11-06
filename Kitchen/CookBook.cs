using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class CookBook
    {
        public CookBook( List<Recipe> recipes )
        {
            this.recipes = recipes;
        }

        public bool Enough_Ingredients( string dishName, Fridge fridge )
        {


            int n = recipes.Count;
            int recipeID = -1;
            for( int i = 0; i<n; i++)
            {
                string thisRecipeName = recipes[i].Return_Name();

                if( thisRecipeName == dishName ) // find recipe with the requested name
                {
                    recipeID = i;
                    Console.WriteLine("** Chosen recipe for: {0}", thisRecipeName);
                    break;
                }
            }

            List<string> recipeIngredientNames = new List<string>();
            List<string> fridgeIngredientNames = fridge.Return_ingredientNames();

            if (recipeID >= 0) recipeIngredientNames = recipes[recipeID].Return_ingredientNames();
            else return false; // return false if there are no recipes with the requested name

            

            int nrec = recipeIngredientNames.Count;
            int nfri = fridgeIngredientNames.Count;

            int foundIngredients = 0;

            for( int i = 0; i<nrec; i++ )
            {
                for( int j = 0; j<nfri; j++)
                {
                    Console.WriteLine("- Comparing {0} and {1} ...",recipeIngredientNames[i], fridgeIngredientNames[j]);
                    if( recipeIngredientNames[i]== fridgeIngredientNames[j]) // find in fridge the #i inredient listed in the recipe
                    {
                        Console.WriteLine("* Found ingredient: {0}", recipeIngredientNames[i]);
                        foundIngredients++;
                        break;
                    }
                }

                if (foundIngredients == nrec) return true; // return true if all recipe ingredients were found in the fridge
            }

            return false;
        }

        private List<Recipe> recipes;
    }
}
