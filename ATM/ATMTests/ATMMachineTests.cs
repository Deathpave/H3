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
        [Theory]
        [InlineData(555)]
        public void Insert(int pass)
        {
            bool result = false;
            // arrange

            CreditCard card = new CreditCard("test", 123, 321, 555);
            BankAccount acc = new BankAccount(123);
            double amount = 1000;

            // act

            if (acc.AccountNumber == card.Account && card.Password == pass)
            {
                acc.Amount += amount;
                result = true;
            }

            // assert
            Assert.Equal(true, result);
        }

    }
}
