using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day04
{
    internal class Program
    {
        enum Weapon
        {
            Sword, Axe, Spear, Mace
        }

        //IndexOf kind of method
        //  returns an index of where the item is found
        //  returns -1 if the item is NOT found
        static int LinearSearch(List<int> searchList, int searchItem)
        {
            int foundIndex = -1;
            for (int i = 0; i < searchList.Count; i++)
            {
                if (searchList[i] == searchItem)
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }
        static void Main(string[] args)
        {
            /*
                ╔═════════╗ 
                ║Searching║
                ╚═════════╝ 
             
                There are 2 ways to search a list: linear search or binary search
             
                CHALLENGE 1:

                    Convert Linear Search algorithm into a method. 
                        The method should take 2 parameters: list of ints to search, int to search for.
                        The method should return -1 if NOT found or the index if found.
                     
                    The algorithm:
                        1) start at the beginning of the list
                        2) compare each item in the list to the search item
                        3) if found, return the index
                        4) if reach the end of the list, return -1 which means not found
                    
            */
            List<int> nums = new List<int>() { 5, 13, 7, 0, 420 };//Count = 5. WORST-CASE: O(N) where N = 5.
            int intToFind = 420;
            int foundIndex = LinearSearch(nums, intToFind);
            if(foundIndex >= 0)
                Console.WriteLine($"{intToFind} was found at index {foundIndex}.");
            else
                Console.WriteLine($"{intToFind} was not found.");
            Console.ReadKey();

            int i1, i2, i3, i4, i5;
            Random randy = new Random();
            int count = randy.Next(10);
            List<int> numbers = new(count);

            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 
                
                [  Creating a Dictionary  ]
                
                Dictionary<TKey, TValue>  - the TKey is a placeholder for the type of the keys. TValue is a placeholder for the type of the values.
                
                When you want to create a Dictionary variable, replace TKey with whatever type of data you want to use for the keys and
                replace TValue with the type you want to use for the values.
            */

            Dictionary<Weapon, int> backpack = new Dictionary<Weapon, int>();//will store the counts of each kind of weapon

            //type of the Keys
            //type of the Values
            Dictionary<string, float> menu = new Dictionary<string, float>()
            {
                //Key-Value pair
                // { key, value }
                { "Eggs", 1.99F },
                { "Toast", 0.99F }
            };
            menu.Add("French Toast", 10.99F);
            menu.Add("Pancakes", 9.99F);
            //menu.Add("Pancakes", 5.99F);//will THROW AN EXCEPTION!

            // [key] = value
            menu["Coffee"] = 2.99F;
            menu["Bacon"] = 5.99F;
            menu["Bacon"] = 7.99F;//will NOT throw an exception. will OVERWRITE the value.
            



            /*  
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Adding items to a Dictionary  ]

                There are 3 ways to add items to a Dictionary:
                1) on the initializer. 
                2) using the Add method. 
                3) using [key] = value
            */
            backpack = new Dictionary<Weapon, int>()
            {
                {Weapon.Sword, 5 }
            };
            backpack.Add(Weapon.Axe, 2);
            backpack[Weapon.Spear] = 1;


            /*
                CHALLENGE 2:

                    Create a Dictionary that stores names (string) and grades. Call the variable grades.
                    Add students and grades to your dictionary 
             
            */


            //Keys MUST BE UNIQUE
            //Values do NOT have to be unique

            List<string> students = new() { "Littal", "Maxwell", "JoshuaGarcia", "Beomjong", "Xander", "Hunter", "Max", 
                "Kevin", "Timothy", "Oliver", "William", "Chanaya",
                "Albert", "Alex", "Geoffery", "JAMES", "Ja'Spring", "JoshuaGilstrap", "Mitchell", "Garrett"
            };
            Dictionary<string, double> grades = new();
            foreach (var name in students)
            {
                //Program Defensively
                //try-catches are expensive
                try
                {
                    grades.Add(name, randy.NextDouble() * 100);
                }
                catch(ArgumentException argument)
                {

                }
                catch(Exception ex) //general catch-all exception
                {
                }

                //OR
                //grades[name] = randy.NextDouble() * 100; 
            }


            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Looping over a Dictionary  ]

                You should use a foreach loop when needing to loop over the entire dictionary.
               
            */
            foreach (KeyValuePair<Weapon,int> weaponCount in backpack)
                Console.WriteLine($"You have {weaponCount.Value} {weaponCount.Key}");


            Console.OutputEncoding = Encoding.Unicode;
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
            Console.WriteLine("-*-*-Bistro PG2-*-*-");
            foreach (KeyValuePair<string, float> menuItem in menu)
            {
                string itemName = menuItem.Key;
                float itemPrice = menuItem.Value;
                Console.WriteLine($"{itemPrice,8:C2} {itemName}");
            }

            //for (int i = 0; i < menu.Count; i++)
            //{
            //    string itemName = menu.Keys.ElementAt(i);
            //    float itemPrice = menu.Values.ElementAt(i);
            //}


            /*
                CHALLENGE 4:

                    Loop over your grades dictionary and print each student name and grade.
             
            */
            PrintGrades(grades);





            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Checking for a key in a Dictionary  ]

                There are 2 ways to see if a key is in the dictionary:
                1) ContainsKey(key)
                2) TryGetValue(key, out value)
               
            */
            if (backpack.ContainsKey(Weapon.Axe))
                Console.WriteLine($"{Weapon.Axe} count: {backpack[Weapon.Axe]}");

            if(backpack.TryGetValue(Weapon.Spear, out int spearCount))
                Console.WriteLine($"{Weapon.Spear} count: {spearCount}");


            /*
                CHALLENGE 5:

                    Using either of the 2 ways to check for a key, look for a specific student in the dictionary. 
                    If the student is found, print out the student's grade
                    else print out a message that the student was not found
             
            */







            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Updating a value for a key in a Dictionary  ]

                To update an exisiting value in the dictionary, use the [ ]
                
               
            */
            backpack[Weapon.Mace] = 0; //sell all maces



            /*
                CHALLENGE 6:

                    Pick any student and curve the grade (add 5) that is stored in the grades dictionary
             
            */
        }

        private static void PrintGrades(Dictionary<string, double> grades)
        {
            Console.WriteLine("    PG2 2308    ");
            foreach (var student in grades)
            {
                string name = student.Key;
                double grade = student.Value;
                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow :
                                          (grade < 89.5) ? ConsoleColor.Blue :
                                                           ConsoleColor.Green;
                Console.Write($"{grade,7:N2} ");//N2 is a number w/ 2 decimal places
                Console.ResetColor();
                Console.WriteLine(name);
            }
        }
    }
}
