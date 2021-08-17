using ATM.DataModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataModels
{
    public class ATMMachine : IATM
    {
        public int ATMNumber { get; private set; }

        public void Insert(double Amount, CreditCard card)
        {
            throw new NotImplementedException();
        }

        public double Withdraw(double Amount, CreditCard card, int Password)
        {
            throw new NotImplementedException();
        }
    }
}
