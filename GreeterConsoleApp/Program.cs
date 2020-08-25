using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterConsoleApp
{
    class Program
    {
        static void Main(string[] args) // this is the entry point for the project running
        {
            string usersName = GetName();
            Console.WriteLine("Hello, " + usersName);
            Console.ReadLine();
        }
        static string GetName()
        {
            Console.WriteLine("Hey! What's your name?");
            string name = Console.ReadLine();
            return name;
        }
    }
}
