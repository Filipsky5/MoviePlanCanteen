using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        public static void printInfo(Dishes.Dish d)
        {
            Console.WriteLine("Cost: " + d.Cost() + "; Ingredients: " + d.Ingredients());
        }
        static void Main(string[] args)
        {
            Dishes.Dish d = new Dishes.Potatoes();
            printInfo(d);

            d = new Dishes.WithSalad(d);
            printInfo(d);

            d = new Dishes.WithCutlet(d);
            printInfo(d);

            Console.ReadKey();
        }
    }
}
