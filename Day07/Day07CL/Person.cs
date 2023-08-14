using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Person
    {
        #region Fields
        private int _age;
        #endregion

        #region Properties
        public int Age 
        { 
            get { return _age; } 
            private set { 
                if(value >= 0 && value < 110)
                    _age = value; 
            } 
        }
        public string Name { get; private set; }
        #endregion

        #region Constructors
        public Person()
        {
            Name = "Bruce Wayne";
            Age = 35;
        }
        public Person(string name, int age)
        {
            //Property = parameter;
            Name = name;
            Age = age;
        }
        #endregion
    }
}
