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
        private int _age = 0;
        #endregion

        #region Properties
        public int Age 
        { 
            get { return _age; } 
            set { 
                if(value >= 0 && value < 110)
                    _age = value; 
            } 
        }
        public string Name { get; private set; } = "Bruce Wayne";
        #endregion
    }
}
