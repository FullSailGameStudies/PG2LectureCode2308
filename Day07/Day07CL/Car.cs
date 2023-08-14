using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Car
    {
        #region Fields
        // FIELDS
        //  _ helps us see that its a field and NOT a local variable
        private string _make;//class-level variable
                             //  make_
                             //  m_sMake  m_Make  mMake _make 


        #endregion

        // PROPERTIES

        public int FuelLevel { get; private set; } = 0;

        public static int NumberOfCarsMade { get; set; } = 0;

        // a FULL property (you create a backing field -- ex: _make)
        public string Make
        {
            // get (accessor)
            //same as..
            //  public string GetMake() {return _make;}
            get { return _make; }

            // set (mutator)
            //same as...
            //  public void SetMake(string value) { _make = value; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value)) //protect the field!
                    _make = value;
            }
        }

        // an AUTO property (the compiler provides the backing field AND the get/set code)
        public string Model { get; private set; }

        public int Year { get; private set; }

        // CONSTRUCTORS (ctor)
        public Car(int year, string make, string model) 
        {
            //property/field = parameter;
            Year = year;
            Make = make;
            Model = model;

            //non-static methods can access static data b/c static data is shared
            NumberOfCarsMade++; 

            //model = Model;//backwards and WRONG!
        }

        #region Methods
        //static methods do NOT have a 'this' parameter
        public static void CarReport()
        {
            Console.WriteLine($"We have made {NumberOfCarsMade} this year!");

            //static methods can ONLY access static data.
            //non-static data is inaccessible.
            //Console.WriteLine($"My car is a {Year} {Make} {Model}");
        }
        public void Refuel(int fuelAmount) //hidden parameter! Car this
        {
            FuelLevel = Math.Min(18, FuelLevel + fuelAmount);
        }
        #endregion
    }
}
