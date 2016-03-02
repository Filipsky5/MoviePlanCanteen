using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class WorkerAgeValidator:WorkerValidator
    {
        public bool validate(Worker worker)
        {
            return worker.Age >= 18;
        }
    }
}
