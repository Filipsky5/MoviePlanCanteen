using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public enum RoleType {Actor,Camerman,Writer,Director };
    public class Worker
    {
        public string Name;
        public RoleType Role;
        public int Age;
    }
}
