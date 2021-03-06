﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Chef
    {
        public Chef(Fridge fridge, CookBook cookBook, Bills bills)
        {
            this.usedFridge = fridge;
            this.usedCookBook = cookBook;
            this.usedBills = bills;

        }

        public Dish Make_Dish(string dishName )
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            List<string> ingredientNames = new List<string>();

            Dish dish = new Dish("",ingredients,0);

                ingredientNames = this.usedCookBook.Return_Ingredients(dishName);

            if (ingredientNames.Count > 1)
            {
                ingredients = Names_To_Ingredients(ingredientNames);

                // remove ingredients from fridge

                int price = usedCookBook.Name_To_Price(dishName);
                dish = new Dish(dishName, ingredients,price);

                Console.WriteLine(" Successfully created dish named \"{0}\".\n", dishName);
            }
            else Console.WriteLine("Too few ingredients in {0}'s recipe.", dishName);

            return dish;            
            
        }


        public List<Ingredient> Names_To_Ingredients( List<string> ingredientNames )
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            int n = ingredientNames.Count;
            for ( int i = 0; i<n; i++ )
            {
                ingredients.Add(new Ingredient(ingredientNames[i]) );
            }

            return ingredients;
        }


        private Fridge usedFridge;
        private CookBook usedCookBook;
        private Bills usedBills;

        
    }
}
