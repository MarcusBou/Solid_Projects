using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybanker
{
    public class Mastercard : CreditCard
    {
        public Mastercard(Account account) : base(account)
        {
            this.prefix = new int[] { 51, 52, 53, 54, 55 };
            this.lengthOfCardNumb = 16;
            this.maxCredit = 40000;
            this.restCredit = 40000;
            this.cardNumber = CreateCardNumber();
            this.expireDate = FindExpireDate(5, 0);
        }

        /// <summary>
        /// makes transaction with credit and not account balance
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public override string MakePaymentWithCard(double price)
        {
            if (this.restCredit < price)
            {
                return "Transaction failed";
            }
            else
            {
                this.restCredit = this.restCredit - price;
                return "transaction succesfull";
            }

        }
    }
}
