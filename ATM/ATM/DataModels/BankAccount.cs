using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataModels
{
    public class BankAccount
    {
        public BankAccount(int accountNumber)
        {
            AccountNumber = accountNumber;
            Amount = 0;
        }
        public int AccountNumber { get; private set; }
        public double Amount { get; set; }
    }
}
