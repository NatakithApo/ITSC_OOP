using OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class FrontendDeveloper : IEmployee, IDeveloper
    {
        public void Meeting()
        {
            Console.WriteLine("Standup Frontend");
        }

        public void Coding()
        {
            Console.WriteLine("Code vue");
        }
    }
}
