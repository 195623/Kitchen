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

        public void Order_Dish(string dishName)
        {
            bills.Add_Dish_To_Newest_Bill(chef.Make_Dish(dishName));
        }

        public void New_Bill_For_Customer( int customerID )
        {
            bills.Add_Bill(customerID);
        }

        public void Display_Bills()
        {
            bills.Display_Bills();
        }

        private Bills bills = new Bills();
        private Fridge fridge = new Fridge();
        private CookBook cookBook = new CookBook();
        private Chef chef ;
        private int newestCustomerID = 0;
    }
}
