using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Coursetry.Entities;

namespace Coursetry.Entities
{
     class BussinesAcount : Acount
    {
        public double LoanLimit { get; set; }

        public BussinesAcount()
        {
        }
        public BussinesAcount(int number,string holder,double balance,double loanlimite) : base (number,holder,balance)
        {
            LoanLimit = loanlimite;
        }
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
        

    }
}
