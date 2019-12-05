using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;     //needed for messagebox capabilities

namespace Polymorphism
{
    class Animal
    {
        //constructor
        public Animal (string species)
        {
            Species = species;
        }

        //species prop
        public string Species { get; set; }

        //MakeSound Method
        public virtual void MakeSound()
        {
            MessageBox.Show("Grrrr");
        }
    }
}
