namespace Day08
{
    /*                    DERIVING CLASSESS          
                                                               
                                ╔═════════╗     ╔══════════╗ 
                 public  class  ║SomeClass║  :  ║OtherClass║ 
                                ╚═════════╝     ╚══════════╝
                                     │                │         
                                     └──┐             └──┐             
                                   ┌────▼────┐      ┌────▼────┐      
                                   │ Derived │      │  Base   │    
                                   │  Class  │      │  Class  │     
                                   └─────────┘      └─────────┘     

    
                CONSTRUCTORS: the derived constructor must call a base constructor
                public SomeClass(.....) : base(....)


     */
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                CHALLENGE 1:

                    In the Day08CL project, add a new class, Pistol, that derives from Weapon.
                    Pistol should have properties for Rounds and MagCapacity.
                    Add a constructor that calls the base constructor
             
            */





            /*  
                ╔═══════════╗ 
                ║ UPCASTING ║ - converting a derived type variable to a base type variable
                ╚═══════════╝ 
                
                This is ALWAYS safe.

                DerivedType A = new DerivedType();
                BaseType B = A;
            



                CHALLENGE 2:
                    Create a List of Weapon. Create several Pistols and add them to the list of weapons.
            */









            /*  
                ╔═════════════╗ 
                ║ DOWNCASTING ║ - converting a base type variable to a derived type variable
                ╚═════════════╝ 
                
                This is NOT SAFE!!!!!

            
                BaseType B = new DerivedType(); //upcasting
                DerivedType A = B; !! Build ERROR !!
            

                3 ways to downcast safely...
                1) explicit cast inside of a try-catch
                    try {  DerivedType A = B;  }
                    catch(Exception) { }

                2) use the 'as' keyword
                    NOTE: null will be assigned to A if B cannot be cast to DerivedType
                    DerivedType A = B as DerivedType;
                    if(A != null) { can use A }

                3) use 'is' in pattern matching
                    if(B is DerivedType A) { can use A }



                CHALLENGE 3:
                    Loop over the list of weapons.
                    Call ShowMe on each weapon.
                    Downcast to a Pistol and print the rounds and mag capacity of each pistol
            */










            /*  
                ╔═════════════╗ 
                ║ OVERRIDING  ║ - changing the behavior of a base method
                ╚═════════════╝ 
                
                2 things are required to override a base method:
                1) add 'virtual' to the base method
                2) add a method to the derived class that has the same signature as the base. put 'override' to the derived method


                FULLY OVERRIDING:
                    not calling the base method from the derived method

                EXTENDING:
                    calling the base method from the derived method




                CHALLENGE 4:
                    Override Weapon's ShowMe method in the Pistol method.
                    In Pistol's version, call the base version and print out the rounds and magCapacity
                    Fix the loop to remove the if-elseif.
            */
        }
    }
}