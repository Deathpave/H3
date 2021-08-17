using ATM.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Managers
{
    public class CardManager
    {
        private List<CreditCard> _cards = new List<CreditCard>();

        public CreditCard NewCreditCard(string cardholder, int account)
        {
            Random random = new Random();
            CreditCard newCard = new CreditCard(cardholder, account, random.Next(1000, 9999), random.Next(1000, 9999));
            _cards.Add(newCard);
            return newCard;
        }
    }
}
