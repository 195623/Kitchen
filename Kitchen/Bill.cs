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
        }

        public void Add_Dish( Dish dish )
        {
            dishes.Add( dish );
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
            return outputString;
        }

        private int customerID;
        private List<Dish> dishes;
    }
}
