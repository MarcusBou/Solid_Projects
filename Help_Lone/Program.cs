using System;


namespace Help_Lone
{
    class Program
    { 
        static void Main(string[] args)
        {
            Barbarian barbarian = new Barbarian();
            barbarian.Bash();
            barbarian.Die();

            Knight knight = new Knight();
            knight.RaiseShield();
            knight.Heal();

            Witch witch = new Witch();
            witch.Teleport(10, 12);
            witch.Fight();

            Wizard wizard = new Wizard();
            wizard.ThrowMagicMisile();
            wizard.ThrowFrostNova();
        }
    }
}
