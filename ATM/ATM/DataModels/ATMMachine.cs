using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataModels
{
    public class ATMMachine
    {
        public int ATMNumber { get; private set; }

        public void Deposit(CreditCard Card, double Amount)
        {
            throw new NotImplementedException();
        }

        public double Withdraw(CreditCard card, int Password, double Amount)
        {
            throw new NotImplementedException();
        }
        public double Balance(CreditCard Card, int Password)
        {
            throw new NotImplementedException();
        }
    }
}
