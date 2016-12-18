using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Bills
    {
        public Bills() {}

        public void Add_Bill(int customerID)
        {
            this.bills.Add(new Bill(customerID));

            //return this;
        }

        public void Add_Dish_To_Newest_Bill( Dish dish )
        {
            //Console.WriteLine("Added dish to newest bill.");

            Return_Last_Bill().Add_Dish(dish);
        }

        public Bill Return_Last_Bill()
        {
            if(bills.Count>0) return bills[bills.Count - 1];

            return null;
        }

        private List<Bill> bills = new List<Bill>();
    }
}
