using System;
using System.Collections.Generic;

namespace Day01
{
    /*                    METHODS          
                                                               
                ╔══════╗ ╔═══╗ ╔══════════╗ ╔════════════════╗ 
                ║public║ ║int║ ║SomeMethod║ ║(int someParam) ║ 
                ╚══════╝ ╚═══╝ ╚══════════╝ ╚════════════════╝ 
                    │      │         │               │         
              ┌─────┘      │         └──┐            └───┐     
         ┌────▼────┐   ┌───▼───┐   ┌────▼───┐       ┌────▼────┐
         │ Access  │   │ Return│   │ Method │       │Parameter│
         │ modifier│   │ type  │   │  Name  │       │  list   │
         └─────────┘   └───────┘   └────────┘       └─────────┘
    
            Vocabulary:
        
                  method (or function): https://www.w3schools.com/cs/cs_methods.php
                      a block of code that can be referenced by name to run the code it contains.

                  parameter: https://www.w3schools.com/cs/cs_method_parameters.php
                      a variable in the method definition.The list of parameters appear between the ( ) in a method header.

                  arguments:
                      when a method is called, arguments are the data you pass into the method's parameters
        
                  return type: https://www.w3schools.com/cs/cs_method_parameters_return.php
                      the value returned when a method finishes.
                      A return type must be specified on a method.
                      If no data is returned, use void.
    
        
                  List<T>: https://www.tutorialsteacher.com/csharp/csharp-list#:~:text=C%23%20-%20List%3CT%3E%201%20List%3CT%3E%20Characteristics%20List%3CT%3E%20equivalent,8%20Check%20Elements%20in%20List%20...%20More%20items
                    a collection of strongly typed objects that can be accessed by index. Indexes start at 0.



             Lecture videos:
                  METHODS LECTURE:
                  https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/EW0hLKhQiBdFjOGq1WG6oRoB9TTQWJd1L9ic6VRiEYwgdg?e=J7uZXt
                  Chapters: Method Basics through Method Examples

                  LIST LECTURE:
                  https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/ERG1iZHKJgFIoj6W8dhxPPgBIIY-Ot1b6Ueh-50Ggfcikg?e=goT9d6
                  Chapters: Array Basics through Looping Examples.

     */
    internal class Program
    {
        static void PrintWorld(string world)//pass by value
        {
            //$ - interpolated string
            Console.WriteLine($"Hello {world}.");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string myWorld = "Spiderverse-808";
            PrintWorld(myWorld);
            Program.PrintWorld("Gotham");
            /*
              Calling a method
                use the methods name.
                1) if the method needs data (i.e. has parameters), you must pass data to the method that matches the parameter types
                2) if the method returns data, it is usually best to store that data in a variable on the line where you call the method.
             
            */

            /*
                ╔══════════════════════════╗ 
                ║Parameters: Pass by Value.║
                ╚══════════════════════════╝ 
             
                Copies the value to a new variable in the method.
                
                For example, the AddOne method has a parameter called localNumber. localNumber is a variable that is local ONLY to the method.
                The value of the variable in main, number, is COPIED to the variable in AddOne, localNumber.
              
            */
            int number = 5;
            int plusOne = AddOne(number);


            /*
                CHALLENGE 1:

                    Add an IsEven method to the calculator.
                    It should take 1 int parameter and return a bool.

                    Call the method on the t1000 calculator instance and print the results.

            */
            Calculator t1000 = new Calculator();//created an instance of Calculator

            //static methods: use the class name
            Calculator.WhoAmI();

            //non-static methods: use the variable instead.
            t1000.Sum(5, 10);
            bool isEven = t1000.IsEven(number);//assign the returned bool to a variable
            Console.WriteLine($"{number} is even? {isEven}");



            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 
                
                [  Creating a List  ]
                
                List<T>  - the T is a placeholder for a type. It is a "Generic Type Parameter" to the class.
                
                When you want to create a List variable, replace T with whatever type of data you want to store in the List.
            */
            List<string> names = new List<string>(10);// { "Aquaman", "Batman", "Wonder Woman" };//this list stores strings and only strings.
            Info(names);//Count: 0  Capacity: 0
            names.Add("Superman");//adds to the END of the list
            Info(names);//Count: 1  Capacity: 4
            names.Add("The Flash");
            names.Add("Green Lantern");
            names.Add("Spiderman");
            names.Insert(3, "Cyborg");
            Info(names);//Count: 5  Capacity: 8? 
            names.Add("Aquaman");
            names.Add("Batman");
            names.Add("Wonder Woman");
            names.Add("Joker");
            Info(names);//Count: 9  Capacity: 12  16
            names.Add("Bane");
            names.Add("Poison Ivy");
            names.TrimExcess();
            Info(names);//Count: 11  Capacity: 20

            Console.WriteLine("\n\n  DC Universe  ");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);//use the indexer
            }
            Console.WriteLine("\n\n  DC Universe  ");
            foreach (var super in names)
            {
                Console.WriteLine(super);
            }

            Console.WriteLine("\n\n");//escape sequences

            string[] best = new string[3] { "Batman", "The Bat", "Bruce" };

            Console.WriteLine("The Best!");
            for (int i = 0; i < best.Length;i++)
            {
                Console.WriteLine(best[i]);//use the indexer
            }
            best[2] = "The Greatest Detective";
            foreach (string name in best)
            {
                Console.WriteLine(name);
            }
            





            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 

                [  Adding items to a List  ]

                There are 2 ways to add items to a list:
                1) on the initializer. 
                2) using the Add method. 
            */
            List<char> letters = new List<char>() { 'B', 'a', 't', 'm', 'a', 'n' };
            letters.Add('!');







            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 

                [  Looping over a List  ]

                You can loop over a list with a for loop or a foreach loop.
                1) for loop. use the Count property in the for condition.
                2) foreach loop
            */
            for (int i = 0; i < letters.Count; i++)
                Console.Write($" {letters[i]}");

            foreach (var letter in letters)
                Console.Write($" {letter}");


            /*
                CHALLENGE 2:

                    Create a list that stores floats. Call the variable grades.
                    Add a few grades to the grades list.
             
                CHALLENGE 3:

                    loop over the grades vector and print out each grade

            */
            List<float> grades = new List<float>();
            Random randy = new Random();
            for (int i = 0; i < 10; i++)
            {
                grades.Add((float)randy.NextDouble() * 100);
            }
            Console.WriteLine("\n\n  PG 2 August Grades  ");
            //for(int i = 0;i < grades.Count;i++)
            //int j = 0;
            //while(j < grades.Count)
            foreach (float grade in grades)
            {
                //float grade = grades[j++];
                //  ,7  right-aligns in 7 spaces
                //  :N2 formats as a number w/ 2 decimal places
                Console.CursorLeft = 6;

                //ternary operator. short-hand for an if-else block
                Console.ForegroundColor = (grade<59.5) ?   ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow :
                                          (grade < 89.5) ? ConsoleColor.Blue : 
                                                           ConsoleColor.Green; 
                Console.WriteLine($"{grade,7:N2}");
            }
            Console.ResetColor();






            /*
                BOSS CHALLENGE: 

                    1) Fix the Average method of the calculator class to calculate the average of the list parameter.
                    2) Call the Average method on the t1000 variable and pass your grades list to the method.
                    3) print the average that is returned.
             
            */


            Console.ReadKey(true);
        }

        private static void Info(List<string> names)
        {
            //Count: # of items in the list
            //Capacity: Length of the internal array
            Console.WriteLine($"Count: {names.Count}\tCapacity: {names.Capacity}");
        }

        private static int AddOne(int localNumber)
        {
            return localNumber + 1;
        }


    }

    class Calculator
    {
        public static void WhoAmI()
        {
            Console.WriteLine("I am a T-800. A cybernetic organism");
        }
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }


        public float Average(List<float> numbers)
        {
            float avg = 0F;

            //loop over the numbers and calculate the average

            return avg;
        }
    }
}
