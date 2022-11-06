using OOP.Interfaces;

namespace OOP.Classes
{
    public class BackendDeveloper : IEmployee, IDeveloper
    {
        public void Meeting()
        {
            Console.WriteLine("Backend Warpup");
        }

        public void Coding()
        {
            Console.WriteLine(".Net 6");
        }
    }
}
