using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybanker
{
    public class Hævekort : Card
    {
        public Hævekort(Account account): base(account)
        {
            this.prefix = new int[] {2400};
            this.lengthOfCardNumb = 16;
            this.cardNumber = CreateCardNumber();
        }
    }
}
