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
            kitchen.Start();

            

            Console.ReadKey();
        }

    }
}
