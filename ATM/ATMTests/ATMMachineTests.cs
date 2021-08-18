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
        public void Deposit(int pass)
        {
            bool result = false;
            // arrange

            CreditCard card = new CreditCard("test", 123, 321, 555);
            BankAccount acc = new BankAccount(123);
            double amount = 1000;

            // act

            if (acc.AccountNumber == card.Account && card.Password == pass)
            {
                acc.Balance += amount;
                result = true;
            }

            // assert
            Assert.Equal(true, result);
        }

        [Theory]
        [InlineData(555, 200)]
        public double Withdraw(int pass, int amount)
        {
            double res = 0;
            CreditCard card = new CreditCard("test", 123, 321, 555);
            BankAccount acc = new BankAccount(123);
            acc.Balance = 200;

            if (acc.AccountNumber == 123 && card.Password == pass && acc.Balance >= amount && amount > 0)
            {
                acc.Balance -= amount;
                res = amount;
            }
            else
            {
                res = 0;
            }

            Assert.Equal(amount, res);
            return res;
        }

        [Theory]
        [InlineData(555)]
        public double Balance(int pass)
        {
            double res = 0;
            CreditCard card = new CreditCard("test", 123, 321, 555);
            BankAccount acc = new BankAccount(123);

            if (card.Password == pass && card.Account == acc.AccountNumber)
            {
                res = acc.Balance;
            }

            Assert.Equal(acc.Balance, res);
            return res;
        }
    }
}
