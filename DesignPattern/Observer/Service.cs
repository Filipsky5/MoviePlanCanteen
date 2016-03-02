using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Service : Observer
    {
        private string Name;
        private string GuestLists;
        private Canteen Canteen;

        public Service (Canteen can, string name)
        {
            this.Canteen = can;
            this.Name = name;
        }

        public override void Update()
        {
            GuestLists = "";
            foreach(Worker w in Canteen.printWorkers())
            {
                GuestLists += w.Name;
            }
            Console.WriteLine("Observer" + this.Name + "get Guest list" + this.GuestLists);
        }
    }
}
