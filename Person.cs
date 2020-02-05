using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_OOP
{
    class Person
    {
        private string name; // field

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    }
}
