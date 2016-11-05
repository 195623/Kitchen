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

                if( thisRecipeName == dishName )
                {
                    recipeID = i;
                    break;
                }
            }

            List<string> recipeIngredientNames = new List<string>();
            List<string> fridgeIngredientNames = fridge.Return_ingredientNames();

            if (recipeID >= 0) recipeIngredientNames = recipes[recipeID].Return_ingredientNames();
            else return false;

            

            int nrec = recipeIngredientNames.Count;
            int nfri = fridgeIngredientNames.Count;

            int foundIngredients = 0;

            for( int i = 0; i<nrec; i++ )
            {
                for( int j = 0; j<nfri; j++)
                {
                    if( fridgeIngredientNames[j]==recipeIngredientNames[i])
                    {
                        foundIngredients++;
                        break;
                    }
                }

                if (foundIngredients == nrec) return true;
            }

            return false;
        }

        private List<Recipe> recipes;
    }
}
