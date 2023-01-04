using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursetry.Entities
{
    class Acount
    {
        

        public int Number { get; private set; }
        public string Holder { get;private set; }
        public double Balance { get;protected set; }

        public Acount()
        {
        }

        public Acount(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(double Amount)
        {
            Balance -= Amount;
        }
        public void Deposito(double Amount)
        {
            Balance += Amount;
        }


    }
}
