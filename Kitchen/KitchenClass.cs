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
            
            bills.Add_Dish_To_Newest_Bill(chef.Make_Dish("Tomato sandwich"));
            bills.Add_Dish_To_Newest_Bill(chef.Make_Dish("Hot dog"));

        }

        private Bills bills = new Bills();
        private Fridge fridge = new Fridge();
        private CookBook cookBook = new CookBook();
        private Chef chef;
    }
}
