using System;
using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    /*                    CLASSESS          
                                                               
                ╔══════╗ ╔═════╗ ╔═════════╗ 
                ║public║ ║class║ ║SomeClass║
                ╚══════╝ ╚═════╝ ╚═════════╝ 
                    │      │         │            
              ┌─────┘      │         └──┐               
         ┌────▼────┐   ┌───▼───┐   ┌────▼───┐       
         │ Access  │   │Keyword│   │ Class  │       
         │ modifier│   │       │   │  Name  │       
         └─────────┘   └───────┘   └────────┘      

    FIELDS - the data of the class

    PROPERTIES - the gatekeepers of the fields

    CONSTRUCTORS - the initializer of the class

    METHODS - the behavior of the class (what the class can do)

    
        
    
        ╔══════════════════╗ 
        ║ ACCESS MODIFIERS ║ - determines who can see it
        ╚══════════════════╝
            public: EVERYONE can see it
            private: ONLY this class can see it  (default)
            protected: this class and all my descendent classes can see it


     */
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                CHALLENGE 1:

                    Create a Person class in Day07CL project.
                    Right-Click the Day07CL project and select "Add > Class..."
             
            */





            /*  
                ╔════════╗ 
                ║ FIELDS ║ - the data of the class
                ╚════════╝ 
                
                use _camelCasingNamingConvention to name your fields in a C# class
            
                CHALLENGE 2:
                    Add an age field to the Person class
            */







            /*  
                ╔════════════╗ 
                ║ PROPERTIES ║ - the gatekeeper (control access) of the fields
                ╚════════════╝ 
                
                use PascalCasingNamingConvention to name your Properties in a C# class

                Properties have a "get" and a "set".
            
                here is a full property
                public int X
                {
                    //same as...public int GetX() {return _x;}
                    get { return _x; }

                    //same as...public void SetX(int value) {_x = value;}
                    set
                    {
                        if (value >= 0 && value < Console.WindowWidth)
                            _x = value;
                    }//value is a keyword
                }

                here is an auto-property (no field or code for the get/set is needed)
                public ConsoleColor Color { get; private set; } = ConsoleColor.DarkCyan;

            
                CHALLENGE 3:
                    Add an Age property provide access to the _age field
                    Add an auto-property for Name
            */






            /*  
                ╔══════════════╗ 
                ║ CONSTRUCTORS ║ - the initializer of the class. Initialize the data of the class.
                ╚══════════════╝ 
                
                RULES FOR CONSTRUCTORS...
                1) cannot have any return type, not even void
                2) must have the same name as the class
                
                HINT: use the ctor code snippet to provide a default contructor

                EXAMPLE:
                public GameObject(int x, int y, ConsoleColor color)
                {
                    X = x;
                    Y = y;
                    Color = color;
                    _numberOfGameObjects++;
                }

            
                CHALLENGE 4:
                    Add a constructor to the Person class to initialize Age and Name
            */






            /*  
                ╔═════════╗ 
                ║ METHODS ║ - the behavior of the class (what it can do)
                ╚═════════╝ 
                
                non-static methods can access the fields/properties/methods of the class
                static methods can only access the static members of the class

                EXAMPLE:
                public virtual void DrawMe()
                {
                    Console.SetCursorPosition(X, Y);
                    Console.BackgroundColor = Color;
                    Console.Write(" ");
                }
                            
                CHALLENGE 5:
                    write an ItsMyBirthday method. increment age and print out a happy message.
            */






            /*                              
                CHALLENGE 6:
                    
                1) create an enum for job position (Intern, JuniorDeveloper, Developer, SeniorDeveloper, LeadDeveloper, VicePresident, President, CEO
                2) add a property to store the person position
                3) create a Promotion method.
                    pass in a parameter for the new position
                    update the property and print out the new position
            */
        }
    }
}
