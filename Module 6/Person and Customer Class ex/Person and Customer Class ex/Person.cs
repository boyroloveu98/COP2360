using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_and_Customer_Class_ex
{
    abstract class Person
    {
        //constructor
        public Person(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        //concrete props
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}