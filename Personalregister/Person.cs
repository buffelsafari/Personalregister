using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    struct Person
    {
        public Person(string name, uint salary)
        {
            this.name = name;
            this.salary = salary;
        }
        
        public uint salary;
        public string name;
    }
}
