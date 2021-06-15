using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    class Register
    {
        private static int nextId=0;

        Dictionary<int, Person> register=new Dictionary<int, Person>();

        public Register()
        { 
            
        }

        public int AddPerson(string name, uint salary)
        {
            int id = nextId++;
            register.Add(id, new Person(name, salary));

            return id;
        }

        public bool GetRegisterLine(ref string line, int id)
        {            
            Person p;
            if (register.TryGetValue(id, out p))
            {
                line = p.name + " " + p.salary.ToString();
                return true;
            }
            return false;
        }

        public int getLastId()
        {
            return nextId;
        }
    }
}
