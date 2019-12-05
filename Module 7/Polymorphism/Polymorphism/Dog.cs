using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;     //needed for messagebox capabilities

namespace Polymorphism
{
    class Dog : Animal
    {
        //constructor
        public Dog (String name) : base("Dog")
        {
            Name = name;
        }

        //name prop
        public string Name { get; set; }

        //make sound method
        public override void MakeSound()
        {
            MessageBox.Show("Woof! Woof!");
        }
    }
}
