using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kitchen;

//TO DO:
// Console.Write -- only in main; other files have only data-outputing functions.

namespace Kitchen_main
{
    class Program
    {
        static void Main()
        {
            KitchenClass kitchen = new KitchenClass();

            kitchen.New_Bill_For_Customer(1);
            kitchen.Order_Dish("Tomato sandwich");
            kitchen.Order_Dish("Hot dog");

            kitchen.Display_Bills();

            

            Console.ReadKey();
        }

    }
}
