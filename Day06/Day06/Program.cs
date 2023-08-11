using System;
using System.Collections.Generic;

namespace Day06
{

    enum Weapon
    {
        Sword, Axe, Spear, Mace
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Removing a key and its value from a Dictionary  ]

                Remove(key) -- returns true/false if the key was found

                You do NOT need to check if the key is in dictionary. Check the returned bool.
               
            */
            Dictionary<Weapon, int> dorasbackpack = new Dictionary<Weapon, int>()
            {
                {Weapon.Sword, 5 }
            };
            dorasbackpack.Add(Weapon.Axe, 2);
            dorasbackpack[Weapon.Spear] = 1;


            bool wasFound = dorasbackpack.Remove(Weapon.Mace);
            if (!wasFound) Console.WriteLine($"{Weapon.Mace} was NOT found.");
            else Console.WriteLine("Mace was removed.");



            /*
                CHALLENGE 1:

                            print the students and grades below
                            ask for the name of the student to drop from the grades dictionary
                            call Remove to remove the student
                            print message indicating what happened
                                error message if not found
                            else print the dictionary again and print that the student was removed

             
            */
            List<string> students = new List<string>() { "Bruce", "Dick", "Diana", "Alfred", "Clark", "Arthur", "Barry" };
            Random rando = new Random();
            Dictionary<string, double> grades = new();
            foreach (var student in students)
                grades.Add(student, rando.NextDouble() * 100);

            do
            {
                PrintGrades(grades);
                Console.Write("Student to drop: ");
                string student = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(student)) break;

                if (grades.Remove(student))
                {
                    Console.WriteLine($"{student} was dropped.");
                }
                else
                    Console.WriteLine($"{student} is not in PG2 this month.");
            } while (true);
        }

        private static void PrintGrades(Dictionary<string, double> grades)
        {
            Console.WriteLine($"\n\n    PG2 {DateTime.Now.Month} {DateTime.Now.Year}    ");
            foreach (KeyValuePair<string, double> student in grades)
            {
                string name = student.Key;
                double grade = student.Value;
                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow :
                                          (grade < 89.5) ? ConsoleColor.Blue :
                                                           ConsoleColor.Green;
                Console.Write($"{grade,7:N2} ");//N2 is a number w/ 2 decimal places formatting specifier
                Console.ResetColor();
                Console.WriteLine(name);
            }
        }
    }
}
