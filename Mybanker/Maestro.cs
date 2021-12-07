using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybanker
{
    public class Maestro : ExpiryCards
    {
        public Maestro(Account account) : base(account)
        {
            this.prefix = new int[] { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };
            this.lengthOfCardNumb = 19;
            this.cardNumber = CreateCardNumber();
            this.expireDate = FindExpireDate(5, 8);
        }
    }
}
