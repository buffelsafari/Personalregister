using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 1. en enkel MVC mönster, view classen bör vara ett interface(hinner inte implementera) och controllern bör vara en subsriber av view classen

// 2. view bör ha all a metoder som behövs för att nödvänding IO till consolen. Controllern bör ha både model classen(registret) och view classen som attribut

// 3. hinner inte med något elegantare lösning på den angivna tiden



namespace Personalregister
{
    class Controller
    {
        ConsoleView view=new ConsoleView();
        Register register = new Register();
        public Controller()
        { 
        
        }

        public void Run()
        {
            while (true)
            {
                view.DisplayInfo();
                string str=view.GetCommandLine();
                string[] split = str.Split(' ');

                if (split.Length > 0)
                {
                    if (split[0].Equals("add"))
                    {
                        if (split.Length == 3)
                        {
                            uint salary;
                            if (uint.TryParse(split[2], out salary))
                            {
                                register.AddPerson(split[1], salary);
                            }
                            else
                            {
                                view.DisplayError();
                            }

                        }
                        else
                        {
                            view.DisplayError();
                        }
                    }
                    else
                    if (split[0].Equals("show"))
                    {
                        if (split.Length == 1)
                        {
                            int lastId=register.getLastId();
                            
                            string line="";

                            for (int i = 0;i<lastId ; i++)
                            {
                                if (register.GetRegisterLine(ref line, i))
                                {
                                    view.DisplayRegisterLine(line);
                                }
                            }
                            
                        }
                        else
                        {
                            view.DisplayError();
                        }

                    }

                }


            }
        }
    }
}
