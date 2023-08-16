using Day08CL;

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

            //Animal animal = new Animal();//animal is abstract. cannot create an instance of it.

            Bird mockingJay = new Bird("Emu", false);//calling the Bird ctor

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
                    Create a List of Weapon. 
                    Create several Pistols and Knives and add them to the list of weapons.
            */
            List<Weapon> dorasBackpack = new List<Weapon>();
            dorasBackpack.Add(new Pistol(40, 100, 9, 9));//upcasting

            Knife knife = new Knife(3, 25, true);
            dorasBackpack.Add(knife);//upcasting

            object weaponObj = knife;

            //Bird flappy = (Bird)knife;


            int num = 5;
            long bigNum = num;//casting? implicit cast
            num = (int)bigNum;//casting? explicit cast

            Mammal hooman = new Mammal("Human", true);

            //UPCASTING:
            //  going from a DERIVED type (Mammal) to a BASE type (Animal)
            Animal animal = hooman; //ALWAYS SAFE

            Console.WriteLine($"This animal has hair? {hooman.HasHair}");





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


            //DOWNCASTING:
            //  from a BASE type (Animal) to a DERIVED type (Bird)
            //  NOT SAFE!!!!!

            //How-to Downcast:
            //1) Explicit w/ try-catch
            try
            {
                Bird flappyBird = (Bird)animal;
            }
            catch(Exception ex)
            {
                Console.WriteLine("The object is not a Bird.");
            }

            //2) use the 'as' keyword to cast w/ a null check
                //if it fails, will assign NULL to the variable
            Bird flappy2 = animal as Bird;
            if(flappy2 != null) //if true, you can use it. the cast succeeded.
                Console.WriteLine($"This bird can fly? {flappy2.CanFly}");

            //3) use the 'is' keyword in an if block  (pattern matching)
            if(animal is Bird flappy3)
                Console.WriteLine($"This bird can fly? {flappy3.CanFly}");



            Console.WriteLine("\nWeapons in Dora's Backpack: ");
            foreach (Weapon weapon in dorasBackpack)
            {
                weapon.ShowMe();
                //downcasting
                if(weapon is Pistol pewpew)
                    Console.WriteLine($"\t{pewpew.Rounds} of {pewpew.MagCapacity}");
                else if(weapon is Knife stabber)
                    Console.WriteLine($"\tIs serrated knife? {stabber.Serrated}");
            }





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