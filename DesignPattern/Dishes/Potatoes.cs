using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dishes
{
    public class Potatoes : Dish
    {
        public double Cost()
        {
            return 1.0;
        }

        public string Ingredients()
        {
            return "Potatoes";
        }
    }
}
