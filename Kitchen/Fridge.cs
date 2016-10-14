using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Fridge
    {
        public Fridge() { }

        public void Request_Ingredients(List<string> orderNames)
        {
            // send list of names to outside database.
        }

        public List<Ingredient> Return_Ingredients()
        {
            return this.ingredients;
        }

        public void Add_Ingredients(List<string> namedIngredients)
        {
            // convert names to Ingredients
            for( int i = 0; i<namedIngredients.Count; i++ )
            {
                ingredients.Add(new Ingredient(namedIngredients[i],i+1));
            }

            //List<Ingredient> newIngredients = Names_To_Ingredients(namedIngredients);

            //this.ingredients.AddRange(newIngredients);
        }

        public void Remove_Ingredients(List<string> namedIngredients)
        {
            // Remove ingredients based on name                                    
        }

        private List<Ingredient> ingredients;
        private int previousID = 0;
    }
}
