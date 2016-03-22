using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Canteen : Subject
    {
        private List<Worker> workers;



        private WorkerValidator validator;

        public Canteen(WorkerValidator val)
        {
            this.validator = val;
            this.workers = new List<Worker>();
        }
         public void addWorker(Worker worker)
        {
            if(validator.validate(worker))
            {
                workers.Add(worker);
                Notify();
            }
        }

        public List<Worker> printWorkers()
        {
            return workers;
        }
    }
}
