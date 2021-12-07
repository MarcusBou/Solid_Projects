using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybanker
{
    public class Account
    {
        private string holderName;
        private int regNr = 3520; //The Registration number for every account
        private string accountNumber;
        private double balance;

        public string HolderName { get { return holderName; }}
        public int RegNr { get { return regNr; }}
        public string AccountNumber { get { return accountNumber; }}
        public double Balance { get { return balance; } set { balance = value; } }

        /// <summary>
        /// takes name param, then creates account with 0 in balance
        /// </summary>
        /// <param name="name"></param>
        public Account(string name)
        {
            this.holderName = name;
            this.balance = 0;
            this.accountNumber = CreateAccountNumber();
        }

        /// <summary>
        /// Method for creating account name, with already preset registrition
        /// </summary>
        /// <returns></returns>
        private string CreateAccountNumber()
        {
            Random random = new Random();
            string accountNum = this.regNr.ToString();
            for (int i = 0; i < 10; i++)
            {
                accountNum += random.Next(0, 10);
            }
            return accountNum;
        }

        /// <summary>
        /// For Deposoting money to, then returns that the deposit was succeesfull
        /// </summary>
        /// <param name="currencyInserted"></param>
        /// <returns></returns>
        public string DepositToAccount(double currencyInserted)
        {
            this.balance = this.balance + currencyInserted;
            return currencyInserted + " has been inserted";
        }
    }
}
