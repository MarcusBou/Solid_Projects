using System;

namespace Mybanker
{
    internal class GUI
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] firstnames = { "Marcus", "Sebastian", "Michael", "Tobias", "Henrik", "Mikkel", "Julie", "Camilla", "Kecia" };
            string[] lastname = { "Jensen", "Frederiksen", "Torbensen", "Karlsen", "Carlsen", "Mikkelsen", "Noundrup", "Laudroup", "Deciplina" };
            Bank_Manager bm = new Bank_Manager();
            for (int i = 0; i < 15; i++)
            {
                bm.CreateAccountWithCardAssigned(firstnames[rnd.Next(0, firstnames.Length)]+ " " + lastname[rnd.Next(0, lastname.Length)]);
            }

            foreach (Card card in bm.ListOverActiveCards)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
