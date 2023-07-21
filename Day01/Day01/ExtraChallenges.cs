using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal static class ExtraChallenges
    {
        public static void Run()
        {
            Challenge1();
            Challenge2();
            Challenge3();
            Challenge4();
            Challenge5();
        }
        #region Challenge1
        private static void Challenge1()
        {
            Console.WriteLine("\n\n--------CHALLENGE 1-----------");
            Console.WriteLine("call the ShowTagline method");

            //call the ShowTagline method

            Continue();
        }
        private static void ShowTagline()
        {
            Console.WriteLine("Because I'm BATMAN!");
        }
        #endregion

        #region Challenge2
        private static void Challenge2()
        {
            Console.WriteLine("\n\n--------CHALLENGE 2-----------");
            Console.WriteLine("pass a year value to the BirthYear method to print the year you were born in");

            //pass a year value to the BirthYear method to print the year you were born in
            BirthYear(0);

            Continue();
        }
        private static void BirthYear(int year)
        {
            Console.WriteLine($"I was born in the year {year}, {DateTime.Now.Year - year} years ago.");
        }
        #endregion

        #region Challenge3
        private static void Challenge3()
        {
            Console.WriteLine("\n\n--------CHALLENGE 3-----------");
            Console.WriteLine("call the CarYear method to set year so that the message prints \"My car was made in 1988!\"");

            int year = 0;
            //call the CarYear method to set year so that the message prints "My car was made in 1988!"

            Console.WriteLine($"My car was made in {year}!");


            Continue();
        }

        private static int CarYear()
        {
            return 1988;
        }
        #endregion


        #region Challenge4
        private static void Challenge4()
        {
            Console.WriteLine("\n\n--------CHALLENGE 4-----------");
            Console.WriteLine("call the FavoriteSeason method to get the message so that it prints \"My favorite season is springtime on Mars.\"");

            string message = "Bob";
            //call the FavoriteSeason method to get the message so that it prints "My favorite season is springtime on Mars."

            Console.WriteLine(message);


            Continue();
        }
        private static void FavoriteSeason(ref string season)
        {
            season = "My favorite season is springtime on Mars.";
        }
        #endregion

        #region Challenge5
        private static void Challenge5()
        {
            Console.WriteLine("\n\n--------CHALLENGE 5-----------");
            Console.WriteLine("call the FavoriteColor method to get the message so that it prints \"My favorite color is DarkMagenta\"");

            ConsoleColor myColor = ConsoleColor.White;
            //call the FavoriteColors method so that it prints "My favorite color is DarkMagenta"

            Console.WriteLine($"My favorite color is {myColor}");


            Continue();
        }
        private static void FavoriteColor(out ConsoleColor favoriteColor)
        {
            favoriteColor = ConsoleColor.Yellow;
        }
        #endregion

        private static void Continue()
        {
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
