using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class KitchenClass
    {
        public KitchenClass()
        {
            chef = new Chef(fridge, cookBook, bills);
        }

        public void Start()
        {            

        }

        public List<string> Order_Dish(string dishName)
        {
            List<string> missingIngredientsNames = cookBook.List_Missing_Ingredients(dishName, fridge);

            if (missingIngredientsNames.Count == 0)
            {
                bills.Add_Dish_To_Newest_Bill(chef.Make_Dish(dishName));
            }
            else
            {
                Console.WriteLine(" Missing ingredients to make the \"{0}\" dish:", dishName);
                for (int i = 0; i < missingIngredientsNames.Count; i++)
                {
                    Console.WriteLine(" - {0}", missingIngredientsNames[i]);
                }

                
            }

            return missingIngredientsNames;
        }


        public List<string> List_Missing_Ingredients( string dishName )
        {
            return this.cookBook.List_Missing_Ingredients(dishName, this.fridge);
        }

        public void New_Bill_For_Customer( int customerID )
        {
            bills.Add_Bill(customerID);
        }

        public void Display_Bills()
        {
            Console.WriteLine(bills.Display_Bills());
        }

        public void Add_Ingredients( List<string> listOfIngredients )
        {
            int n = listOfIngredients.Count;
            for( int i = 0; i<n; i++ )
            {
                this.fridge.Add_Ingredient(listOfIngredients[i]);
            }
        }

        private Bills bills = new Bills();
        private Fridge fridge = new Fridge();
        private CookBook cookBook = new CookBook();
        private Chef chef ;
        private int newestCustomerID = 0;
    }
}
