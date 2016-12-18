using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Bill
    {
        public Bill(int billID, int customerID)
        {
            this.billID = billID;
            this.customerID = customerID;
            dishes = new List<Dish>();
        }

        public void Add_Dish( Dish dish )
        {
            dishes.Add(dish);
        }

        public void Display_Bill()
        {
            int n = dishes.Count;

            Console.WriteLine("\nList of dishes in customer #{0}'s bill #{1}:",customerID,billID);

            for(int i = 0; i<n; i++ )
            {
                Console.WriteLine("- {0}",dishes[i].Return_Name());
            }
        }

        private int billID;
        private int customerID;
        private List<Dish> dishes;
    }
}
