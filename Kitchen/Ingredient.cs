using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    

    class Ingredient
    {
        public Ingredient(string name, int ingredientID)
        {
            this.name = name;
            this.ingredientID = ingredientID;
        }

        private int ingredientID;
        private string name;
    }
}
