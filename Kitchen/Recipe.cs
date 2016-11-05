using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Recipe
    {
        public Recipe(string name, List<string> ingredientNames )
        {
            this.name = name;
            this.ingredientNames = ingredientNames;
        }

        private string name;
        private List<string> ingredientNames;
    }
}
