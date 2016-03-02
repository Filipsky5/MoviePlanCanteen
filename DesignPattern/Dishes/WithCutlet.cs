using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dishes
{
    public class WithCutlet : DishDecorator
    {
        public WithCutlet(Dish d) : base(d)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 2;
        }

        public override string Ingredients()
        {
            return base.Ingredients() + ", Cutlet";
        }
    }
}
