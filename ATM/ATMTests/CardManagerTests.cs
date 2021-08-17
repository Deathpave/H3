using ATM.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATMTests
{
    public class CardManagerTests
    {

        [Theory]
        [InlineData("test", 123]
        public CreditCard NewCard(string cardholder, int account)
        {
            Random random = new Random();
            CreditCard newCard = new CreditCard(cardholder, account, random.Next(1000, 9999), random.Next(1000, 9999));
            return newCard;
        }
    }
}
