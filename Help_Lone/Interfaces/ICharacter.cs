using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Lone
{
    interface ICharacter
    {
        public void Heal();
        public void Die();
        public void Fight();
    }
}
