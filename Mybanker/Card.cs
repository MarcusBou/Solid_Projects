using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybanker
{
    public abstract class Card
    {
        protected Account account;
        protected int[] prefix;
        protected int lengthOfCardNumb;
        protected string cardNumber;

        public Account Account { get { return account; } }
        public int[] Prefix { get { return prefix; } protected set { prefix = value; } }
        public int LengthOfCardNumb { get { return lengthOfCardNumb; } protected set { lengthOfCardNumb = value; } }
        public string CardNumber { get { return cardNumber; } protected set { cardNumber = value; } }

        protected Card(Account acc)//Creates card with account attached
        {
            this.account = acc;
        }

        /// <summary>
        /// For taking a random prefix in the prefix array, then takes length and adds a number for the length
        /// </summary>
        /// <returns></returns>
        protected string CreateCardNumber()
        {
            Random random = new Random();
            string prefixNumb = prefix[random.Next(0, prefix.Length)].ToString();
            string cardNumb = prefixNumb;
            for (int i = 0; i < (LengthOfCardNumb - prefixNumb.Length); i++)
            {
                cardNumb += random.Next(0, 10);
            };
            return cardNumb;
        }

        /// <summary>
        /// For Making a payment with the card, where it checks if price is greater then balance
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public virtual string MakePaymentWithCard(double price)
        {
            if (account.Balance < price)
            {
                return "Transaction failed";
            }
            else
            {
                account.Balance = account.Balance - price;
                return "transaction succesfull";
            }
        }

        public override string ToString()
        {
            string stringed = String.Format("[CardNumber]: {0} [Owner]: {1} [Balance]: {2}", CardNumber, account.HolderName, account.Balance);//Format for a Default Hævekort
            return stringed;
        }
    }
}
