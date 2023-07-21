using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public static class Input
    {
        public static string GetInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static bool ValidInteger(int number, int min, int max)
        {
            return (number >= min && number <= max);
        }

        public static int GetInteger(string message, int min, int max)
        {
            do
            {
                string input = GetInput(message);
                if (int.TryParse(input, out int number) && ValidInteger(number, min, max))
                    return number;
                Console.WriteLine("That is not a valid number.");
            } while (true);
        }

        public static bool ValidString(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        public static void GetString(string message, ref string output)
        {
            do
            {
                output = GetInput(message);
                if (ValidString(output))
                    break;

                Console.WriteLine("That is not a valid string.");
            } while (true);
        }

        public static void GetMenuChoice(string message, List<string> options, out int selection)
        {
            foreach (string option in options)
                Console.WriteLine(option);

            selection = GetInteger(message, 1, options.Count);
        }
    }
}
