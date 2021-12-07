using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybanker
{
    public abstract class ExpiryCards : Card
    {
        protected DateTime expireDate;
        public DateTime ExpireDate { get { return expireDate; } }
        public ExpiryCards(Account account) : base(account)
        {

        }

        /// <summary>
        /// Takes Today date, adds a certain amount of years and months and return the date of expire
        /// </summary>
        /// <param name="years"></param>
        /// <param name="months"></param>
        /// <returns></returns>
        protected DateTime FindExpireDate(int years, int months)
        {
            DateTime date = DateTime.Today;
            date = date.AddYears(years);
            date = date.AddMonths(months);
            return date;
        }
        public override string ToString()
        {
            return String.Format(base.ToString() + " [Expire date]: {0}", this.expireDate.Month.ToString() + "/" + this.expireDate.Year.ToString());
        }
    }
}
