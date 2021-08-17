using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataModels.Interfaces
{
    internal interface IATM
    {
        void Insert(double Amount, CreditCard card);
        double Withdraw(double Amount, CreditCard card, int Password);
    }
}
