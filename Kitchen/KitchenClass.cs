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
        { }

        public void Start()
        {
            int thisCustomerID = 1;

            chef = new Chef(fridge, cookBook, bills);

            bills.Add_Bill(thisCustomerID);
            Order_Dish("Tomato sandwich");
            Order_Dish("Hot dog");

            bills.Display_Bills();

        }

        void Order_Dish(string dishName)
        {
            bills.Add_Dish_To_Newest_Bill(chef.Make_Dish(dishName));
        }

        private Bills bills = new Bills();
        private Fridge fridge = new Fridge();
        private CookBook cookBook = new CookBook();
        private Chef chef;
    }
}
