using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Bill
    {
        public Bill(int customerID)
        {
            this.customerID = customerID;
            dishes = new List<Dish>();
            this.totalCost = 0;

        }

        public void Add_Dish( Dish dish )
        {
            dishes.Add( dish );
            totalCost+=dish.Return_Price();
        }

        public string Display_Bill()
        {
            string outputString = "";
            string custID = customerID.ToString();

            int n = dishes.Count;

            outputString += "\nList of dishes in the bill of customer #";
            outputString += custID;
            outputString += ":\n";

            for(int i = 0; i<n; i++ )
            {
                outputString += "- ";
                outputString += dishes[i].Return_Name() ;
                outputString += '\n';
            }

            outputString += "\n\nTotal cost: ";
            outputString += totalCost.ToString();
            outputString += ".";

            return outputString;
        }

        public int Bill_Price()
        {
            int price = 0;

            for( int i = 0; i<dishes.Count;i++)
            {
                price += dishes[i].Return_Price();
            }

            return price;
        }

        public int Return_TotalCost()
        {
            return this.totalCost;
        }

        private int customerID;
        private List<Dish> dishes;
        private int totalCost;
    }
}
