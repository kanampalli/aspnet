// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace GreetingApp
{
    class Program
    {
        static void Main()
        {
            // Greet the user
            Console.WriteLine("Welcome to the GreetingApp!");

            // Get the current date and time
            DateTime currentDateTime = DateTime.Now;

            // Display the date and time
            Console.WriteLine($"Current Date and Time: {currentDateTime}");
        }
    }
}
