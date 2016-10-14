using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Dish
    {
        public Dish(int dishID, List<Ingredient> ingredients)
        {
            this.dishID = dishID;
            this.ingredients = ingredients;
        }

        private int dishID;
        private List<Ingredient> ingredients;
    }
}
