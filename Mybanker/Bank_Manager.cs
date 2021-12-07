using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybanker
{
    public class Bank_Manager
    {
        private List<Account> listOverAccount;
        private List<Card> listOverActiveCards;

        public List<Account> ListOverAccount { get { return listOverAccount; } }
        public List<Card> ListOverActiveCards { get { return listOverActiveCards; } }

        public Bank_Manager()
        {
            this.listOverAccount = new List<Account>();
            this.listOverActiveCards = new List<Card>();
        }

        /// <summary>
        /// This is a method for demonstration purposes of being able to run and create cards and account
        /// </summary>
        /// <param name="person"></param>
        public void CreateAccountWithCardAssigned(string person)
        {
            Random random = new Random();
            Account acc = new Account(person);
            Card card;
            listOverAccount.Add(acc);
            int numbForDiffCards = random.Next(0, 5);
            switch (numbForDiffCards)
            {
                case 0:
                    card = new Hævekort(acc);
                    listOverActiveCards.Add(card);
                    break;
                case 1:
                    card = new Maestro(acc);
                    listOverActiveCards.Add(card);
                    break;
                case 2: 
                    card = new Mastercard(acc);
                    listOverActiveCards.Add(card);
                    break;
                case 3:
                    card = new Visa_Electron(acc);
                    listOverActiveCards.Add(card);
                    break;
                case 4:
                    card = new Visa_Dankort(acc);
                    listOverActiveCards.Add(card);
                    break;
                default:
                    break;
            }
        }
    }
}
