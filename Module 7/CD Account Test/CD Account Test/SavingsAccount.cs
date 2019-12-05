using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class SavingsAccount
    {
        //constructor
        public SavingsAccount()
        {
            AccountNumber = "";
            InterestRate = 0;
            Balance = 0;
        }

        //props
        public string AccountNumber { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Balance { get; set; }
        
    }
}
