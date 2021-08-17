using ATM.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATMTests
{
    public class AccountManagerTests
    {
        [Theory]
        [InlineData(12456)]
        public BankAccount NewBankAccount(int accountnumber)
        {
            BankAccount bankAccount = new BankAccount(accountnumber);
            return bankAccount;
        }
    }
}
