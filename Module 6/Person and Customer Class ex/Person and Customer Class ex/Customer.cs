using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_and_Customer_Class_ex
{
    class Customer : Person
    {
        //constructor
        public Customer(string name, string address, string customerNumber, string phone, bool allowsSolicitation) 
            :base(name, address, phone)
        {
            Id = customerNumber;
            allowsSolicitation = true;
        }

        //props
        public string Id;

        //concrete props
        public bool allowsSolicitation { get; set; }
    }
}
