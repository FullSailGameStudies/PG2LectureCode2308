using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{
    public abstract class Animal
    {
        public Animal(string name)
        {
            Name = name;//Property = parameter
        }
        public string Name { get; set; }

        public virtual void Move() 
        {
            Console.WriteLine("Time to move somewhere...");
        }
        public void Reproduce() { }
    }

    public class Bird : Animal  //an is-a relationship. a Bird is-a animal
    {
        // order of execution: Base ctor then derived ctor
        //construct the Animal parts also to make a complete Bird instance
        //the Bird ctor needs to call a ctor of the Animal class
        public Bird(string name, bool canFly) : base(name)  //new Animal(name)
        {
            CanFly = canFly;
            Console.WriteLine($"I'm a bird ({Name}).");
        }
        public bool CanFly { get; set; } //a has-a relationship. A Bird has-a property CanFly

        public override void Move()
        {
            //EXTEND the base version (add-on to it)
            //call the base method
            base.Move();//if you don't call the base method, you are FULLY overriding


            if (CanFly)
                Console.WriteLine("flap flap flap");
            else
                Console.WriteLine("run run run");
        }
    }


    //child class or derived class or a specialization
    public class Mammal : Animal  //now, everything from Animal is part of Mammal
    {
        public bool HasHair { get; set; } = true;

        public Mammal(string name, bool hasHair) : base(name)
        {
            HasHair = hasHair;//assign the parameter to the property
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("run run run");
        }
    }
}
