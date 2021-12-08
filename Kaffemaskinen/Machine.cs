using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    /// <summary>
    /// A superclass called machine having the power element
    /// </summary>
    public abstract class Machine
    {
        private bool powerstate;
        public bool Powerstate { get { return powerstate; } }
        public Machine()
        {
            powerstate = false;
        }
        public void ChangePowestate(bool newPowerState)
        {
            powerstate = newPowerState;
        }
    }
}
