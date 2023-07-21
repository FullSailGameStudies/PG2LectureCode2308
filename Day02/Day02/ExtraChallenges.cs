using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal static class ExtraChallenges
    {
        private static List<string> _supers = new List<string>();


        public static void Run()
        {
            Challenge1();
            Challenge2();
            Challenge3();
            Challenge4();
            Challenge5();
        }

        private static void Challenge1()
        {
            Console.WriteLine("\n\n--------CHALLENGE 1-----------");
            Console.WriteLine("Add 4 superheroes to the _supers list using the Add method");

            //Add 4 superheroes to the _supers list using the Add method

            Continue();
        }
        private static void Challenge2()
        {
            Console.WriteLine("\n\n--------CHALLENGE 2-----------");
            Console.WriteLine("Loop over _supers with a for loop and print out each superhero name");

            //Loop over _supers with a for loop and print out each superhero name

            Continue();
        }
        private static void Challenge3()
        {
            Console.WriteLine("\n\n--------CHALLENGE 3-----------");
            Console.WriteLine("Loop over _supers with a foreach loop and print out each superhero name");

            //Loop over _supers with a foreach loop and print out each superhero name

            Continue();
        }
        private static void Challenge4()
        {
            Console.WriteLine("\n\n--------CHALLENGE 4-----------");
            Console.WriteLine("Remove one of the superheroes using the Remove method then print out the list");

            //Remove one of the superheroes using the Remove method then print out the list

            Continue();
        }
        private static void Challenge5()
        {
            Console.WriteLine("\n\n--------CHALLENGE 5-----------");
            Console.WriteLine("Remove one of the superheroes using the RemoveAt method then print out the list");

            //Remove one of the superheroes using the RemoveAt method then print out the list

            Continue();
        }

        private static void Continue()
        {
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
