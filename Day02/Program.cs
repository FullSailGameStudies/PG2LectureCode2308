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
        static void Main(string[] args)
        {

            /*   
                ╔══════════════════════════════╗ 
                ║Parameters: Pass by Reference.║
                ╚══════════════════════════════╝ 
                Sends the variable itself to the method. The method parameter gives the variable a NEW name (i.e. an alias)
                  
                NOTE: if the method assigns a new value to the parameter, the variable used when calling the method will change too.
                    This is because the parameter is actually just a new name for the other variable.
            */
            string spider = "Spiderman";
            bool isEven = PostFix(ref spider);



            /*  
                ╔═══════════════════════════╗ 
                ║Parameters: Out Parameters.║
                ╚═══════════════════════════╝  
                  A special pass by reference parameter. 
                  DIFFERENCES:
                    the out parameter does NOT have to be initialized before sending to the method
                    the method MUST assign a value to the parameter before returning

            */
            ConsoleColor randoColor; //don't have to initialize it
            GetRandomColor(out randoColor);
            Console.BackgroundColor = randoColor;
            Console.WriteLine("Hello Gotham!");
            Console.ResetColor();





            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 

                [  Removing from a List  ]

                There are 2 main ways to remove from a list:
                1) bool Remove(item).  will remove the first one in the list that matches item. returns true if a match is found else removes false.
                2) RemoveAt(index). will remove the item from the list at the index

            */
            List<string> dc = new() { "Batman", "Wonder Woman", "Aquaman", "Superman", "Aquaman" };
            bool found = dc.Remove("Aquaman");

            dc.RemoveAt(dc.Count - 1);//removes the last item



            /*   
                ╔═══════════════════════════════╗ 
                ║Parameters: optional parameters║
                ╚═══════════════════════════════╝ 
                
                Unless specified, parameters to a method are required.
                However, you can make parameters optional, meaning when calling the method, you aren't required to pass values for the optional parameters.

                REQUIREMENT:
                    - all optional parameters have to be at the end of the list of parameters
                    - in the list of parameters, assign a value to any parameter you want to be optional
            */
            string file = "highScores";
            string postfile = PostFix(file); //if you don't pass a value, the default value will be used for the optional parameter
            postfile = PostFix(file, 5); //if a value is passed, it will be used for the optional parameter



            Console.ReadKey();


            List<string> menu = new List<string>()
            { "1. Add Pizza to Order (ref params)", "2. Get Bill (out params)", "3. Remove Topping (List remove)", "4. Remove Toppings (remove in a loop)", "5. Get Bill w/ Custom Tip (optional param)", "6. Exit" };


            Order order = new Order();
            int selection;
            do
            {
                Console.Clear();
                ShowTitle();
                Console.WriteLine("Order Pizzas");
                Input.GetMenuChoice("Choice? ", menu, out selection);
                Console.Clear();
                switch (selection)
                {
                    case 1:

                        /*
                            CHALLENGE 1:

                            Finish the Build method in the PizzaBuilder class. 
                            --
                            --  USE PASS BY REFERENCE
                            --
                            The Build method should call methods called GetSize, GetCrust, GetSauce, and GetTopping. Randomly pick the item in the methods.
                                use pass by reference to return the size/crust/sauce/topping from each method.

                            Use the values from the Get methods to set the properties on a Pizza instance.
                            NOTE: add 3 toppings to the pizza
                            RETURN the pizza instance.

                            Call the method from Main and add the pizza returned to the Order instance.
                            Call the AddPizza method on the order instance.


                            https://www.tutorialspoint.com/csharp/csharp_reference_parameters.htm

                            LECTURE VIDEOS:
                            https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/EW0hLKhQiBdFjOGq1WG6oRoB9TTQWJd1L9ic6VRiEYwgdg?nav=eyJwbGF5YmFja09wdGlvbnMiOnsic3RhcnRUaW1lSW5TZWNvbmRzIjoxMzQzLjcsInRpbWVzdGFtcGVkTGlua1JlZmVycmVySW5mbyI6eyJzY2VuYXJpbyI6IkNoYXB0ZXJTaGFyZSIsImFkZGl0aW9uYWxJbmZvIjp7ImlzU2hhcmVkQ2hhcHRlckF1dG8iOmZhbHNlfX19fQ&e=tRSoen

                        */
                        break;
                    case 2:

                        /*
                            CHALLENGE 2: 
                            --
                            --  USE OUT PARAMS
                            --
                            Add 4 overloads for a GetCost methods to the PizzaBuilder class. 
                                One will get the cost of the size. One will get the cost of the crust. etc. 
                                Return the cost using an OUT param.

                            Add a GetPrice method to the Pizza class. 
                                It should call the GetCost methods for each of the items. 
                                return the price using an out param.

                            Add a GetPrice method to the Order class.
                                calculate the subTotal, 8% tax, 15% tip, and total price for the list of pizzas
                                use out params to return the subTotal, taxAmount, tipAmount, and total.
                        

                            https://www.tutorialspoint.com/csharp/csharp_reference_parameters.htm

                            LECTURE VIDEOS:
                            https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/EW0hLKhQiBdFjOGq1WG6oRoB9TTQWJd1L9ic6VRiEYwgdg?nav=eyJwbGF5YmFja09wdGlvbnMiOnsic3RhcnRUaW1lSW5TZWNvbmRzIjoxOTcwLjg2LCJ0aW1lc3RhbXBlZExpbmtSZWZlcnJlckluZm8iOnsic2NlbmFyaW8iOiJDaGFwdGVyU2hhcmUiLCJhZGRpdGlvbmFsSW5mbyI6eyJpc1NoYXJlZENoYXB0ZXJBdXRvIjpmYWxzZX19fX0&e=MVPbKw
                        */
                        break;
                    case 3:

                        /*
                            CHALLENGE 3:
                            --
                            --  removing from a List
                            --
                            Write a RemoveTopping method to the Order class.
                                it should have a Topping parameter.
                                it should loop over the pizzas and remove the topping from each pizza.


                            List.Remove: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.remove?view=net-7.0
                            List.RemoveAt: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.removeat?view=net-7.0

                            LECTURE VIDEOS:
                            https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/ERG1iZHKJgFIoj6W8dhxPPgBIIY-Ot1b6Ueh-50Ggfcikg?nav=eyJwbGF5YmFja09wdGlvbnMiOnsic3RhcnRUaW1lSW5TZWNvbmRzIjoyMTg0LjU0LCJ0aW1lc3RhbXBlZExpbmtSZWZlcnJlckluZm8iOnsic2NlbmFyaW8iOiJDaGFwdGVyU2hhcmUiLCJhZGRpdGlvbmFsSW5mbyI6eyJpc1NoYXJlZENoYXB0ZXJBdXRvIjpmYWxzZX19fX0&e=JBaSMe
                        */
                        break;
                    case 4:

                        /*
                            CHALLENGE 4:
                            --
                            --  removing multiple items from a List
                            --
                            Write a RemoveToppings method to the Order class.
                                it should have a List of Topping parameter.
                                it should loop over the pizzas and remove each topping from each pizza.

                        */
                        break;
                    case 5:

                        /*
                            CHALLENGE 5:
                            --
                            --  USE OPTIONAL PARAMS
                            --
                            Modify the GetPrice method of the order class to have an optional tip parameter. 
                                The default tip should be is 15%
                                If a number is passed in, use that number to calculate the tipAmount.
                        

                            https://www.w3schools.com/cs/cs_method_parameters_default.php

                            LECTURE VIDEOS:
                            https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/EW0hLKhQiBdFjOGq1WG6oRoB9TTQWJd1L9ic6VRiEYwgdg?nav=eyJwbGF5YmFja09wdGlvbnMiOnsic3RhcnRUaW1lSW5TZWNvbmRzIjoyNTY5LjU3NywidGltZXN0YW1wZWRMaW5rUmVmZXJyZXJJbmZvIjp7InNjZW5hcmlvIjoiQ2hhcHRlclNoYXJlIiwiYWRkaXRpb25hbEluZm8iOnsiaXNTaGFyZWRDaGFwdGVyQXV0byI6ZmFsc2V9fX19&e=hn58se
                        */
                        int tip = Input.GetInteger("Tip percentage? ", 1, 25);


                        break;
                }

            } while (selection != menu.Count);

            ShowPizza();

        }

        private static void GetRandomColor(out ConsoleColor outColor)
        {
            //the method MUST initialize the outColor parameter
            outColor = (ConsoleColor)randy.Next(16);

        }

        static bool PostFix(ref string hero) //hero is now an alias to the variable used when calling PostFix. In this case, hero is an alias to the spider variable.
        {
            int postFix = randy.Next(100);
            hero += $"-{postFix}"; //updating hero now also updates spider
            return postFix % 2 == 0; //isEven
        }
        static string PostFix(string fileName, int postFixNumber = 1) //postFixNumber is optional
        {
            return fileName + postFixNumber;
        }



        #region Show Methods
        static string _title =
            @"
__/\\\\\\\\\\\\\_______________________________________________________/\\\__/\\\___________        
__\/\\\/////////\\\____________________________________________________\/\\\_\/\\\__________       
___\/\\\_______\/\\\__/\\\_____________________________________________/\\\\\\\\\\\\\_______      
____\/\\\\\\\\\\\\\/__\///___/\\\\\\\\\\\__/\\\\\\\\\\\__/\\\\\\\\\____\///\\\///\\\/_______     
_____\/\\\/////////_____/\\\_\///////\\\/__\///////\\\/__\////////\\\_____\/\\\_\/\\\_______    
______\/\\\_____________\/\\\______/\\\/_________/\\\/______/\\\\\\\\\\___/\\\\\\\\\\\\\____   
_______\/\\\_____________\/\\\____/\\\/_________/\\\/_______/\\\/////\\\__\///\\\///\\\/____  
________\/\\\_____________\/\\\__/\\\\\\\\\\\__/\\\\\\\\\\\_\//\\\\\\\\/\\___\/\\\_\/\\\____ 
_________\///______________\///__\///////////__\///////////___\////////\//____\///__\///____
";

        internal static void ShowTitle()
        {
            string[] lines = _title.Split('\n');
            foreach (string line in lines)
            {
                foreach (char c in line)
                {
                    Console.ForegroundColor = (c == '_') ? ConsoleColor.DarkYellow : ConsoleColor.DarkCyan;
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.WriteLine("\n");
        }


        static string _pizza =
@"
                                                      ▓▓▓▓  ▓▓▓▓▓▓▓▓▓▓                                          
                                              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                        
                                      ▒▒▒▒▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▓▓                                        
                                ▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▓▓                                        
                            ▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▓▓▓▓                                        
                        ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓░░░░                                      
                      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒░░░░░░░░░░                                    
                    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▓▓▓▓▒▒░░░░░░░░░░▓▓▓▓▓▓▓▓                                  
                ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓                                
              ▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░                            
            ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░  ▓▓▓▓▓▓▓▓  ░░░░                            
          ▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▓▓▓▓▒▒░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░      ░░░░                          
          ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░          ░░░░                        
      ▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒░░░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░▓▓▓▓▓▓▓▓  ░░░░░░                      
    ▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░██▓▓▓▓▓▓▓▓▓▓  ░░░░░░                    
  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░████▓▓▓▓▓▓▓▓░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓    ░░                    
  ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓    ░░░░░░                
  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒░░░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████▓▓▓▓▓▓▓▓░░    ░░░░░░░░              
  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░      ░░░░              
  ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░      ░░░░            
  ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░██▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░      ░░░░          
    ▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░░░████▓▓▓▓▓▓▓▓░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░    ░░░░░░        
      ▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░░░░░░░░░░░░░████░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░    ░░░░        
          ▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░████▓▓▓▓▓▓▓▓░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░    ░░░░░░      
              ▒▒▒▒▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░    ░░░░░░      
                  ▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░    ░░░░░░    
                    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░  ▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████▓▓▓▓▓▓▓▓░░░░░░░░    ░░░░░░    
                            ▒▒▒▒▒▒░░░░  ▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██████░░░░░░░░░░░░    ░░░░░░    
                                  ▒▒░░░░▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░  ░░░░░░░░  
                                  ▒▒░░    ▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    ░░░░░░  
                                    ░░░░      ░░░░░░  ▒▒▒▒░░░░░░░░░░░░░░░░▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░  ░░░░░░  
                                    ░░░░░░      ░░░░  ░░▒▒░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░    ░░░░  
                                      ░░░░      ░░░░░░░░  ▒▒░░░░░░  ░░░░▒▒▒▒▒▒▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░      ░░  
                                        ░░░░    ░░░░  ░░  ░░░░░░░░  ░░░░▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░  
                                          ░░░░  ░░░░░░░░    ░░░░░░  ░░▒▒        ▒▒▒▒▒▒▒▒▒▒▓▓░░░░░░░░░░░░░░  ░░  
                                            ░░░░░░░░▒▒      ░░░░░░░░░░░░              ▒▒▒▒▒▒░░░░  ▒▒▓▓▒▒░░  ░░  
                                              ░░░░░░░░      ░░░░░░░░░░░░              ░░    ░░░░░░░░▒▒░░░░  ░░  
                                              ░░░░░░▒▒        ░░░░░░░░░░                    ░░░░░░░░▒▒▒▒░░  ░░  
                                                ▒▒░░░░        ░░░░  ▒▒                        ░░░░░░▒▒▒▒░░  ░░  
                                                ░░░░░░        ░░░░░░░░                        ░░░░▒▒▒▒▒▒░░  ░░  
                                                  ░░░░        ░░░░                            ▒▒  ░░    ░░  ░░  
                                                  ░░░░        ░░░░                            ░░  ░░    ░░  ░░  
                                                  ░░          ▒▒░░                            ░░  ░░    ▒▒░░░░  
                                                  ░░            ░░                            ░░  ░░      ░░░░  
                                                                ░░                            ░░░░░░      ░░░░  
                                                                ░░                              ░░░░      ░░░░  
                                                                ░░                              ░░░░      ░░░░  
                                                                ░░                                        ░░░░  
                                                                ░░                                        ░░░░  
                                                              ░░  ░░                                    ░░░░░░░░
                                                              ░░░░                                      ░░      
                                                                ░░                                    ░░░░      
                                                                                                      ░░░░░░  ░░
                                                                                                        ░░░░░░  
";

        internal static void ShowPizza()
        {
            string[] lines = _pizza.Split('\n');
            foreach (string line in lines)
            {
                foreach (char c in line)
                {
                    Console.ForegroundColor = (c == '░') ? ConsoleColor.Yellow : 
                                              (c == '▓') ? ConsoleColor.DarkRed :
                                              (c == '█') ? ConsoleColor.Red :
                                              (c == '▒') ? ConsoleColor.DarkYellow :
                                              ConsoleColor.Black;
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.WriteLine("\n");
        }
        #endregion
    }
}