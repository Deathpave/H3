using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataModels
{
    public class CreditCard
    {
        public CreditCard(string cardHolder, int account, int regNumber, int password)
        {
            CardHolder = cardHolder;
            Account = account;
            RegNumber = RegNumber;
            Password = password;

            CardNumber = new Random().Next(1000, 10000);
        }

        public int CardNumber { get; private set; }
        public string CardHolder { get; private set; }
        public int Account { get; private set; }
        public int RegNumber { get; private set; }
        public int Password { get; private set; }
    }
}
