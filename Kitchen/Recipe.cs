using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Recipe
    {
        public Recipe(string name, List<string> ingredientNames, int price )
        {
            this.name = name;
            this.ingredientNames = new List<string>(ingredientNames);
            this.price = price;
        }

        public string Return_Name()
        {
            return this.name;
        }

        public List<string> Return_ingredientNames()
        {
            return this.ingredientNames;
        }

        public int Return_price()
        {
            return this.price;
        }

        private string name;
        private List<string> ingredientNames;
        private int price;
    }
}
