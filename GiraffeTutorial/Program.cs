// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiraffeTutorial
{
    class Program
    {
        static void print(string text)
        {
            Console.WriteLine(text);
        }


        static void Main(string[] args)
        {
            /*
            // Write to console
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");


            // Variables
            string characterName = "George";
            int characterAge = 35;

            Console.WriteLine($"There once was a man named {characterName}");
            Console.WriteLine($"He was {characterAge} years old");
            Console.WriteLine($"He really liked the name {characterName}");
            Console.WriteLine($"But didn't like being {characterAge}");


            // Data Types

            // Plain text
            string phrase = "Scooby Doo"; // String
            char grade = 'A'; // Single Character


            // Numbers
            int age = 30; // Whole numbers
                          // Decimal types: float (precise), double (more precise), decimal (most precise / exact)
            double gpa = 3.3;

            // Boolean
            bool isMale = true;
            bool isFemale = false;


            // Working With Strings

            Console.WriteLine("test");
            */

            // Oppgave 1
            // a

            /*
            int num1 = 10;
            int num2 = 10;

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is larger than {num2}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"{num2} is larger than {num1}");
            }
            else
            {
                Console.WriteLine("The numbers are the same.");
            }
            */


            /*
            var myCar = new Dictionary<string, string>()
            {
                {"Brand", "Ford"},
                {"Model", "Explorer"},
                {"Year", "2022"}
            };

            foreach (var i in myCar)
            {
                Console.WriteLine(i);
            }
            */

            /*
            List<string> myCars = new List<string>();

            myCars.Add("Ford");
            myCars.Add("Opel Zafira");
            myCars.Add("Opel Astra");

            int cars = 0;
            foreach (string car in myCars)
            {
                Console.WriteLine($"Wow! You have a(n) {car}?");
                cars += 1;
            }
            Console.WriteLine($"Wow! You have {cars} cars!?");
            */

            print("Hello");
        }
    }
}