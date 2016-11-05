using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class CookBook
    {
        public CookBook( List<Recipe> recipes )
        {
            this.recipes = recipes;
        }

        private List<Recipe> recipes;
    }
}
