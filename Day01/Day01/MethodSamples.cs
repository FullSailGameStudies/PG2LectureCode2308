using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
                  method(or function) : https://www.w3schools.com/cs/cs_methods.php
                      a block of code that can be referenced by name to run the code it contains.

                  parameter: https://www.w3schools.com/cs/cs_method_parameters.php
                      a variable in the method definition.The list of parameters appear between the ( ) in a method header.

                  arguments:
                      when a method is called, arguments are the data you pass into the method's parameters
        
                  return type: https://www.w3schools.com/cs/cs_method_parameters_return.php
                      the value returned when a method finishes.
                      A return type must be specified on a method.
                      If no data is returned, use void.



             Lecture videos:
                  METHODS LECTURE:
                  https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/EW0hLKhQiBdFjOGq1WG6oRoB9TTQWJd1L9ic6VRiEYwgdg?e=J7uZXt
                  Chapters: Method Basics through Method Examples
    */

    internal class MethodSamples
    {


        #region Return Types

        /*
            ╔═══════════╗ 
            ║Return type║ The return type defines the type of the data being returned.
            ╚═══════════╝        
        */

        #region void return type

        //
        //  If no data is returned from the method, use "void" as the return type
        //
        public void DoSomething()
        {
            Console.WriteLine("Something");
        }
        #endregion

        #region returning data
        //
        // If a method returns data,
        // then the return type must match the type of the data being returned.
        // In this sample, the method returns a float value so the return type is "float"
        //
        public float GetMyGrade()
        {
            return 99.9F; //returning a float so set return type to float
        }

        //
        //to call GetMyGrade successfully, you would usually store the returned data in a variable
        //
        public void CallingGetMyGrade()
        {
            //assign the value that is returned from GetMyGrade in a variable of the same type as the return type.
            //GetMyGrade returns a float so the variable myGrade should be a float
            float myGrade = GetMyGrade();

            //now do something with the data
            Console.WriteLine($"My grade is {myGrade}");
        }
        #endregion
        #endregion

        #region Parameters
        /*

            ╔══════════╗ 
            ║Parameters║ Parameters define the data passed to the method.
            ╚══════════╝

            Arguments vs Parameters
        */


        #region No Parameters
        //
        //  If NO data is passed to the method, leave the parenthesis empty. EX: ( )
        //
        public void PrintSomething()//no parameters
        {
            Console.WriteLine("Something");
        }

        //
        //  Calling a method with no parameters means you use empty ( )
        //
        public void CallingPrintSomething()
        {
            //even though PrintSomething has no parameters, you still need to use empty ( ) when calling it.
            PrintSomething();
        }
        #endregion

        #region Passing Arguments
        //
        // If the method requires some data to do its work, 
        // then define the variable the method will use to store the data.
        //
        // Parameters are just variables therefore parameters need 2 things: <type> <name>
        //
        // In this example, "myGrade" is a parameter.
        // "myGrade" is assigned a value when the method is called.
        // EX: PrintMyGrade(95.7F); 95.7 will be assigned to myGrade
        //
        public void PrintMyGrade(float myGrade)
        {
            Console.WriteLine($"My grade is {myGrade}");
        }

        //
        //  Calling a method with parameters means you need to pass arguments that satisfy the types of the parameters
        //
        public void CallingPrintMyGrade()
        {
            //PrintMyGrade has 1 required parameter of type "float"
            //when calling PrintMyGrade, you need to pass an argument that is a float or can be converted to a float
            float myPG2Grade = 99.9F;
            PrintMyGrade(myPG2Grade);
        } 
        #endregion
        #endregion
    }
}
