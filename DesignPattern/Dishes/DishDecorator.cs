using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dishes
{
    public class DishDecorator : Dish
    {
        protected Dish decaratedDish;

        public DishDecorator (Dish d)
        {
            this.decaratedDish = d;
        }

        public virtual double Cost()
        {
            return this.decaratedDish.Cost();
        }

        public virtual string Ingredients()
        {
            return this.decaratedDish.Ingredients();
        }
    }
}
