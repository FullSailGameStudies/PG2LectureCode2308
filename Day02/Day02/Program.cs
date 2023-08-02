using System;
using System.Collections.Generic;
using System.Linq;

namespace Day02
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


    
    ╔═══════════╗ 
    ║Return type║ Return type defines the type of the data being returned.
    ╚═══════════╝
    │
    │
    └── If NO data is returned, then use "void" for the return type.
    │    public void PrintSomething()
    │    {
    │        Console.WriteLine("Something");
    │    }
    │
    │
    └── If a method returns data, then the return type must match the type of the data being returned.
        public float GetMyGrade()
        {
            return 99.9F; //returning a float so set return type to float
        }

    ╔══════════╗ 
    ║Parameters║ Parameters define the data passed to the method.
    ╚══════════╝
    │
    │
    └── If NO data is passed to the method, leave the parenthesis empty. EX: ( )
    │    public void PrintSomething()
    │   {  }
    │
    │
    └── If passing data to the method, then define the variable the method will use to store the data.
        Parameters are just variables therefore parameters need 2 things: <type> <name>
        Example:
        public void PrintMyGrade(float myGrade)
        {
            Console.WriteLine($"My grade is {myGrade}");
        }

        

     */
    internal class Program
    {
        static Random randy = new Random();

        static void GetGrades(ref List<float> listOfGrades)
        {
            /*
                CHALLENGE 1:

                    Write a method to create and fill a list of floats with grades.
                    1) pass it in a list variable by reference
                    2) initialize the list
                    3) add 10 grades to the list

            */
            listOfGrades = new List<float>();
            for (int i = 0; i < 10; i++)
            {
                double grade = randy.NextDouble() * 100;
                listOfGrades.Add((float)grade);
            }
        }
        static void GetStats(List<float> listOfGrades, out float min, out float max, out float avg)
        {
            min = listOfGrades[0];
            max = listOfGrades[0];
            avg = 0;
            for (int i = 0; i < listOfGrades.Count; i++)
            {
                if(min > listOfGrades[i]) min = listOfGrades[i];
                if(max < listOfGrades[i]) max = listOfGrades[i];
                avg += listOfGrades[i];
            }
            avg /= listOfGrades.Count;
        }
        //tuple
        static (float,float,float) GetStats(List<float> listOfGrades)
        {
            float min = listOfGrades.Min();
            float max = listOfGrades.Max();
            float avg = listOfGrades.Average();
            return (min,max,avg);
        }

        static void Main(string[] args)
        {
            Console.CursorLeft = 15;
            Console.WriteLine("Batman");//move to the 0,currentLine+1 next line
            Console.CursorLeft = 15;
            Console.Write("Aquaman");
            float val = (float)randy.NextDouble();

            /*   
                ╔══════════════════════════════╗ 
                ║Parameters: Pass by Reference.║
                ╚══════════════════════════════╝ 
                Sends the variable itself to the method. The method parameter gives the variable a NEW name (i.e. an alias)
                  
                NOTE: if the method assigns a new value to the parameter, the variable used when calling the method will change too.
                    This is because the parameter is actually just a new name for the other variable.
            */
            Console.WriteLine();
            string spider = "Spiderman";
            Console.WriteLine(spider);
            bool isEven = PostFix(ref spider);
            Console.WriteLine(spider);
            Console.ReadKey();

            /*
                CHALLENGE 1:

                    Write a method to create and fill a list of floats with grades.
                    1) pass it in a list variable by reference
                    2) initialize the list and add 10 grades to the list

            */
            double grade = randy.NextDouble() * 100;

            List<float> pg2 = null;//1) must be assigned to before calling the method
            GetGrades(ref pg2);//2) use the 'ref' keyword on both ends
            PrintGrades(pg2);
            Console.ReadKey();


            /*  
                ╔═══════════════════════════╗ 
                ║Parameters: Out Parameters.║
                ╚═══════════════════════════╝  
                  A special pass by reference parameter. 
                  DIFFERENCES:
                    the out parameter does NOT have to be initialized before sending to the method
                    the method MUST assign a value to the parameter before returning

            */
            string numStr = "5";
            bool isGood = int.TryParse(numStr, out int number);


            ConsoleColor randoColor; //don't have to initialize it
            //while (true)
            //{
            //    int x = randy.Next(Console.WindowWidth);//0->(windowwidth-1)
            //    int y = randy.Next(Console.WindowHeight-1);
            //    Console.SetCursorPosition(x, y);

            //    bool isBlack = GetRandomColor(out randoColor);
            //    Console.BackgroundColor = randoColor;
            //    Console.Write("Hello Gotham!"); 

            //    if(randy.Next(1000) == 500)
            //    {
            //        //Console.Clear();
            //        string bats = "                            BATMAN!                             ";
            //        Console.SetCursorPosition(Console.WindowWidth/2 - bats.Length/2,
            //            Console.WindowHeight/2);
            //        Console.WriteLine(bats);
            //    }
            //}
            Console.ResetColor();

            /*
                CHALLENGE 2:

                    Write a method to calculate the stats on a list of grades
                    1) create a method to calculate the min, max, and avg. 
                        pass in the list of grades.
                        use out parameters to pass this data back from the method.
                    3) print out the min, max, and avg
             
            */

            //GetStats(pg2, out float min, out float max, out float average);

            (float min, float max, float average) = GetStats(pg2);
            Console.WriteLine($"Min: {min}\nMax: {max}\nAverage: {average}");



            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 

                [  Removing from a List  ]

                There are 2 main ways to remove from a list:
                1) bool Remove(item).  will remove the first one in the list that matches item. returns true if a match is found else removes false.
                2) RemoveAt(index). will remove the item from the list at the index

            */
            List<string> dc = new() { "Batman", "Wonder Woman", "Aquaman", "Aquaman", "Superman", "Aquaman" };
            Console.WriteLine("  BEFORE remove  ");
            foreach (string name in dc) Console.WriteLine(name);

            bool found = dc.Remove("Aquaman");

            Console.WriteLine("  AFTER remove  ");
            foreach (string name in dc) Console.WriteLine(name);

            dc.RemoveAt(dc.Count - 1);//removes the last item

            /*
                CHALLENGE 3:

                    Using the list of grades you created, 
                    Remove all the failing grades (grades < 59.5).
                    Print the grades.
            */
            for (int i = 0; i < pg2.Count; i++)
            {
                if (pg2[i] < 59.5)
                {
                    pg2.RemoveAt(i);
                    i--;
                    //pg2.Remove(pg2[i]);//less efficient b/c it starts at the beginning of the list
                }
            }
            //OR use a reverse for loop
            //for (int i = pg2.Count - 1; i >= 0; i--)
            //{
            //    if (pg2[i] < 59.5)
            //        pg2.RemoveAt(i);
            //}
            ////OR
            //for (int i = 0; i < pg2.Count;)
            //{
            //    if (pg2[i] < 59.5)
            //        pg2.RemoveAt(i);
            //    else
            //        i++;
            //}
            ////OR
            //int j = 0;
            //for(; ;) //while(true)
            //{
            //    if (pg2[j] < 59.5)
            //        pg2.RemoveAt(j);
            //    else
            //        j++;

            //    //how to get out of this loop?
            //    if (j == pg2.Count) break;
            //}
            PrintGrades(pg2);
            //RemoveAll method. uses lambda statement.




        }

        private static void PrintGrades(List<float> pg2)
        {
            Console.WriteLine("---PG2---");
            foreach (float pg2Grade in pg2)
            {
                Console.WriteLine($"{pg2Grade,7:N2}");
            }
        }

        private static bool GetRandomColor(out ConsoleColor outColor)
        {
            //the method MUST initialize the outColor parameter
            outColor = (ConsoleColor)randy.Next(16);
            return outColor == ConsoleColor.Black;
        }

        static bool PostFix(ref string hero) //hero is now an alias to the variable used when calling PostFix. In this case, hero is an alias to the spider variable.
        {
            int postFix = randy.Next(100);
            hero += $"-{postFix}"; //updating hero now also updates spider
            return postFix % 2 == 0; //isEven
        }
    }
}
