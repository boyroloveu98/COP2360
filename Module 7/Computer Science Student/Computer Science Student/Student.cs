using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Science_Student
{
    abstract class Student
    {
        //constructor
        public Student(string name, string id)
        {
            Name = name;
            ID = id;
        }

        //concrete props
        public string Name {get; set;}
        public string ID {get; set;}

        //requiredHours Prop
        public abstract double RequiredHours { get; }
    }
}
