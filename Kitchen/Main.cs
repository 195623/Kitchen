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

            // Order_Dish outputs a List<string>

            List<string> missingIngredients = new List<string>();

            missingIngredients.AddRange(kitchen.Order_Dish("Tomato sandwich"));

            missingIngredients.AddRange(kitchen.Order_Dish("Hot dog"));

            // Request missingIngredients from the TRANSPORT module
            Console.WriteLine("\n\n  Ingredients missing in all dishes:");

            for(int i = 0; i<missingIngredients.Count; i++ )
            {
                Console.WriteLine("  - {0},", missingIngredients[i]);
            }

            Console.WriteLine("\n");

            kitchen.Display_Bills();

            

            Console.ReadKey();
        }

    }
}
