using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kitchen;

namespace Kitchen_main
{
    class Program
    {
        static void Main()
        {
            List<Recipe> recipes = new List<Recipe>();

            List<string> ingredientNames = new List<string>();
            ingredientNames.Add("Bread");
            ingredientNames.Add("Butter");
            ingredientNames.Add("Tomato");
            Recipe thisRecipe = new Recipe("Sandwich", ingredientNames);
            recipes.Add(thisRecipe);          

            ingredientNames.Clear();

            ingredientNames.Add("Bread");
            ingredientNames.Add("Weiner");
            ingredientNames.Add("Tomato");
            thisRecipe = new Recipe("Hot dog", ingredientNames);
            recipes.Add(thisRecipe);

            //--------

            CookBook cookBook = new CookBook(recipes);

            Fridge fridge = new Fridge() ;

            fridge.Add_Ingredient("Tomato");
            fridge.Add_Ingredient("Bread");
            fridge.Add_Ingredient("Butter");

            //List<Ingredient> ingredients = fridge.Return_Ingredients();

            Chef chef = new Chef();
            Dish dish = chef.Make_Dish("Tomato sandwich",fridge);

            Console.ReadKey();
        }

    }
}
