using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybanker
{
    public class Visa_Dankort: CreditCard
    {
        public Visa_Dankort(Account account): base(account)
        {
            this.prefix = new int[] { 4 };
            this.lengthOfCardNumb = 16;
            this.maxCredit = 20000;
            this.restCredit = 20000;
            this.cardNumber = CreateCardNumber();
            this.expireDate = FindExpireDate(5, 0);
        }
        /// <summary>
        /// Makes transaction with credit and not accountbalance, and can go into negative.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public override string MakePaymentWithCard(double price)
        {
            this.restCredit = restCredit - price;
            return "Transaction Succesfull";

        }

        /// <summary>
        /// Resets if it also has gone below zero in the value
        /// </summary>
        public override void ResetCreditsFromCard()
        {
            if (restCredit < 0)
            {
                double creditOverused = maxCredit - restCredit;//minus minus equals plus, which explain this formular
                this.account.Balance = this.account.Balance - creditOverused;
                restCredit = maxCredit;
            }
            else
            {
                base.ResetCreditsFromCard();
            }
        }
    }
}
