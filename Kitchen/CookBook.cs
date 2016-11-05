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
            List<string> ingredientNames = fridge.Return_ingredientNames();

            int n = ingredientNames.Count;
            for( int i = 0; i<n; i++)
            {

            }

            return false;
        }

        private List<Recipe> recipes;
    }
}
