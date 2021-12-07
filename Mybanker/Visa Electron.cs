using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybanker
{
    public class Visa_Electron: ExpiryCards
    {
        private double maxUsage;
        private double usage;
        public double MaxUsage { get { return maxUsage; } }
        public double Usage { get { return usage; } }
        public Visa_Electron(Account account): base(account)
        {
            this.prefix = new int[] { 4026, 417500, 4508, 4844, 4913, 4917 };
            this.lengthOfCardNumb = 16;
            this.cardNumber = CreateCardNumber();
            this.expireDate = FindExpireDate(5, 0);
            this.maxUsage = 10000;
        }

        /// <summary>
        /// for making a payment and with the neccesary limit checks
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public override string MakePaymentWithCard(double price)
        {
            if (account.Balance < price && usage >= maxUsage && (usage + price) > maxUsage)//Sets extra checks for sure not to over extend limit
            {
                return "Transaction failed";
            }
            else
            {
                account.Balance = account.Balance - price;
                return "transaction succesfull";
            }
        }
    }
}
