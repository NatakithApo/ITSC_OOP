using OOP.Classes;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tester tester = new Tester();
            tester.Meeting();

            FrontendDeveloper frontendDeveloper = new FrontendDeveloper();
            frontendDeveloper.Meeting();
            frontendDeveloper.Coding();

            BackendDeveloper backendDeveloper = new BackendDeveloper();
            backendDeveloper.Meeting();
            backendDeveloper.Coding();
        }
    }
}