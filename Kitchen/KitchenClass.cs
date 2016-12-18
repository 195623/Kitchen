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
            CookBook cookBook = new CookBook();

            Fridge fridge = new Fridge();

            Chef chef = new Chef(fridge, cookBook, bills);
            Dish dish = chef.Make_Dish("Tomato sandwich");

            Console.WriteLine("Main: Made dish: \"{0}\"", dish.Return_Name());

            Bill bill = new Bill(1, 1);
            bill.Add_Dish(dish);
            bill.Display_Bill();

            bills.Add_Bill(bill);
        }

        public void Order_Food( string foodName )
        {

        }

        private Bills bills = new Bills();
    }
}
