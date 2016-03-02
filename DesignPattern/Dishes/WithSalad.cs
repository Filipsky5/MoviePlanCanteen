using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dishes
{
    public class WithSalad : DishDecorator
    {
        public WithSalad(Dish d) : base(d)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 0.5;
        }

        public override string Ingredients()
        {
            return base.Ingredients() + ", Salad";
        }
    }
}
