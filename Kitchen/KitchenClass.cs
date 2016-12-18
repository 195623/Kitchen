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

            chef = new Chef(fridge, cookBook, bills);
            this.Order_Food("Tomato sandwich");

        }

        public void Order_Food( string foodName )
        {
            Dish dish = chef.Make_Dish(foodName);

            Console.WriteLine("Main: Made dish: \"{0}\"", dish.Return_Name());

            Bill bill = new Bill(1, 1);
            bill.Add_Dish(dish);
            bill.Display_Bill();

            bills.Add_Bill(bill);
        }

        private Bills bills = new Bills();
        private Fridge fridge = new Fridge();
        private CookBook cookBook = new CookBook();
        private Chef chef;
    }
}
