// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiraffeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write to console
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");



            // Variables
            string characterName = "George";
            int characterAge;
            characterAge = 35;

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

        }
    }
}