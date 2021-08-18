using ATM.Managers;
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

        public double Deposit(CreditCard Card, int Password, double Amount)
        {
            // add handling for double exceeding max val

            double res = 0;
            BankAccount acc = AccountManager.GetAccounts().Where(o => o.AccountNumber == Card.Account).FirstOrDefault();

            if (acc != null && Card.Password == Password)
            {
                try
                {
                    acc.Balance += Amount;
                    res = Amount;
                }
                catch (OverflowException)
                {
                    res = 0;
                }
            }

            return res;
        }

        public double Withdraw(CreditCard card, int Password, double Amount)
        {
            double res = 0;
            BankAccount acc = AccountManager.GetAccounts().Where(o => o.AccountNumber == card.Account).FirstOrDefault();

            if (acc != null && card.Password == Password && acc.Balance >= Amount && Amount > 0)
            {
                acc.Balance -= Amount;
                res = Amount;
            }
            else
            {
                res = 0;
            }

            return res;
        }
        public double Balance(CreditCard Card, int Password)
        {
            double res = 0;
            BankAccount acc = AccountManager.GetAccounts().Where(o => o.AccountNumber == Card.Account).FirstOrDefault();

            if (acc != null && Card.Password == Password && Card.Account == acc.AccountNumber)
            {
                res = acc.Balance;
            }

            return res;
        }
    }
}
