using ATM.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATMTests
{
    public class ATMMachineTests
    {

        [Fact]
        public bool Insert()
        {

            // arrange

            CreditCard card = new CreditCard("test", 123, 321, 555);
            BankAccount acc = new BankAccount(123);
            double amount = 1000;

            // act

            if (acc.AccountNumber == card.Account && card.Password == 555)
            {
                acc.Amount += amount;
                return true;
            }
            else
            {
                return false;
            }
            // assert
        }
    }
}
