using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Dish
    {
        public Dish(string dishName, List<Ingredient> ingredients, int price )
        {
            this.dishName = dishName;
            this.ingredients = new List<Ingredient>(ingredients);
            this.price = price;         
        }

        public string Return_Name()
        {
            return this.dishName;
        }

        public int Return_Price()
        {
            return this.price;
        }

        private string dishName;
        private List<Ingredient> ingredients = new List<Ingredient>();
        private int price;
    }
}
