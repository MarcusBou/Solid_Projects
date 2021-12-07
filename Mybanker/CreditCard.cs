using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybanker
{
    public abstract class CreditCard: ExpiryCards
    {
        protected double maxCredit;
        protected double restCredit;

        public double MaxCredit { get { return maxCredit; } }
        public double RestCredit { get { return restCredit;} }
        public CreditCard(Account account) : base(account)
        {

        }

        /// <summary>
        /// Method resets credits on card, then removes used money on balance for account
        /// </summary>
        public virtual void ResetCreditsFromCard()
        {
            double creditUsed = maxCredit - restCredit;
            this.account.Balance = this.Account.Balance - creditUsed;
            restCredit = creditUsed;
        }

        public override string ToString()
        {
            return string.Format("[CardNumber]: {0} [Owner]: {1} [CreditLeft]: {2}  [Expire date]: {3}/{4}", CardNumber, account.HolderName, restCredit, this.expireDate.Month.ToString(),this.expireDate.Year.ToString());
        }
        
    }
}
