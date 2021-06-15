using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    class ConsoleView
    {
        public ConsoleView()
        { 
        
        }

        internal void DisplayInfo()
        {
            Console.WriteLine("commands:");
            Console.WriteLine("add name salary");
            Console.WriteLine("show");
        }

        internal string GetCommandLine()
        {
            return Console.ReadLine();
        }

        internal void DisplayError()
        {
            Console.WriteLine("input error!");
        }

        internal void DisplayRegisterLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
