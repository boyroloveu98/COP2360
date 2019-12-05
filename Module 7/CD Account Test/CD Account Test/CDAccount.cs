using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class CDAccount : SavingsAccount
    {
        //constructor
        public CDAccount()
        {
            MaturityDate = "";
        }

        //Maturity date prop
        public string MaturityDate { get; set; }
    }
}
